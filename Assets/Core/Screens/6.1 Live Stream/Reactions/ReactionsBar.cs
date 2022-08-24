using UnityEngine;
using UnityEngine.Events;

public class ReactionsBar : MonoBehaviour
{
    [SerializeField] private ReactionButton[] _reactionButtons;
    [SerializeField] private UnityEvent<ReactionButton> _reactionButtonChanged;
    [SerializeField] private UnityEvent<ReactionButton> _reactionButtonsActivated;
    [SerializeField] private UnityEvent<ReactionButton> _reactionButtonsDeactivated;

    public ReactionButton ActiveReactionButton { get; private set; }

    public void ProcessReactionButtonPress(ReactionButton reactionButton)
    {
        if(reactionButton.Active)
        {
            ProcessActiveButton(reactionButton);
        }
        else
        {
            ProcessUnactiveButton(reactionButton);
        }
    }

    private void ProcessActiveButton(ReactionButton reactionButton)
    {
        ActiveReactionButton.Deactivate();
        ActiveReactionButton = null;
        _reactionButtonsDeactivated.Invoke(reactionButton);
    }

    private void ProcessUnactiveButton(ReactionButton reactionButton)
    {
        DeactivateAllButtons();
        ActiveReactionButton = reactionButton;
        reactionButton.Activate();
        _reactionButtonChanged.Invoke(reactionButton);
        _reactionButtonsActivated.Invoke(reactionButton);
    }

    private void DeactivateAllButtons()
    {
        foreach (var button in _reactionButtons)
        {
            if(button.Active)
            {
                button.Deactivate();
            }
        }
    }
}