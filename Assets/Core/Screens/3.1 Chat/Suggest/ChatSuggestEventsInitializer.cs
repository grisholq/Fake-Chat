using UnityEngine;

public class ChatSuggestEventsInitializer : MonoBehaviour
{
    [SerializeField] private ChatSuggestionsList _suggestions;
    [SerializeField] private ChatSuggestEvents _events;

    public void InitializeEvents()
    {
        foreach (var suggestion in _suggestions.Suggestions)
        {
            suggestion.SuggestionMessageSend += _events.CallSuggestPressedEvent;
        }
    }
}