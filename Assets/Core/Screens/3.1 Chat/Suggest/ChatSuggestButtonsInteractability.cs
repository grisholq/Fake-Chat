using UnityEngine;

public class ChatSuggestButtonsInteractability : MonoBehaviour
{
    [SerializeField] private ChatSuggestionsList _suggestions;

    private void OnEnable()
    {
        EnableInteractability();
    }

    public void DisableInteractability()
    {
        foreach (var suggest in _suggestions.Suggestions)
        {
            suggest.Button.interactable = false;
        }
    }
    
    public void EnableInteractability()
    {
        foreach (var suggest in _suggestions.Suggestions)
        {
            suggest.Button.interactable = true;
        }
    }
}