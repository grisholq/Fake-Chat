using System.Collections.Generic;
using UnityEngine;

public class ChatSuggestUIInitializer : MonoBehaviour
{
    [SerializeField] private Transform _restartButton;
    [SerializeField] private ChatSuggestUI _messageSuggerPrefab;
    [SerializeField] private Transform _parent;
    [SerializeField] private ChatSuggestionsList _suggestions;

    public void InitializeUI()
    {
        Character choosen = Characters.Instance.ChoosenCharacter;
        ChatMessage[] messages = choosen.ChatMessages;

        foreach (var message in messages)
        {
            ChatSuggestUI suggest = InstantiateSuggestMessage();
            suggest.Message = message;
        }

        _suggestions.Suggestions = GetComponentsInChildren<ChatSuggestUI>();
        _restartButton.SetAsLastSibling();
    }

    private ChatSuggestUI InstantiateSuggestMessage()
    {
        return Instantiate(_messageSuggerPrefab, _parent);
    }
}