using UnityEngine;
using UnityEngine.Events;

public class TypingAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    public UnityEvent<string> TextChanged;
    public UnityEvent AnimationPlayed;

    private string _textReset = "Online";
    private string[] _textStates = { "Typing", "Typing.", "Typing..", "Typing..." };

    int state;

    public void Play()
    {
        _animator.SetTrigger("Type");
    }

    public void ChangeState()
    {
        state++;

        if(state >= 4)
        {
            state = 0;
        }

        TextChanged.Invoke(_textStates[state]);
    }

    public void ResetText()
    {
        TextChanged.Invoke(_textReset);
        AnimationPlayed.Invoke();
    }

    private void OnDisable()
    {
        _animator.SetTrigger("Stop");
        TextChanged.Invoke(_textReset);
    }
}