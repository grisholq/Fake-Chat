using System.Collections.Generic;
using UnityEngine;

public class ChatHistoryUpdater : MonoBehaviour
{
    [SerializeField] private ChatMessageAdder _messageAdder;
    [SerializeField] private Transform _messagesParent;


    private void OnEnable()
    {
        UpdateHistory();
    }

    public void UpdateHistory()
    {
        ClearHistory();
        ShowHistory();
    }

    public void ShowHistory()
    {
        Character choosen = Characters.Instance.ChoosenCharacter;
        List<ChatMessage> history = CharacterChatUtility.GetChatHistory(choosen);

        foreach (var message in history)
        {
            _messageAdder.AddMessage(message);
        }
    }

    public void ClearHistory()
    {
        for (int i = 0; i < _messagesParent.childCount; i++)
        {
            Destroy(_messagesParent.GetChild(i).gameObject);
        }
    }
}