using UnityEngine;
using UnityEngine.Events;

public class ChatMessageAdder : MonoBehaviour
{
    [SerializeField] private ChatLastMessage _lastMessage;
    [SerializeField] private MyMessageUI _myMessagePrefab;
    [SerializeField] private OtherMessageUI _otherMessagePrefab;
    [SerializeField] private Transform _messagesParent;

    public void AddMessage(ChatMessage message)
    {
        _lastMessage.Message = message;

        MyMessageUI myMessage = InstantiateMyMessage();
        myMessage.SetText(message.Question);
        _lastMessage.Question = myMessage;

        OtherMessageUI otherMessage = InstantiateOtherMessage();
        otherMessage.SetText(message.Anwser);
        _lastMessage.Anwser = otherMessage;
    }

    private MyMessageUI InstantiateMyMessage()
    {
        MyMessageUI messageUI = Instantiate(_myMessagePrefab, _messagesParent);
        return messageUI;
    }

    private OtherMessageUI InstantiateOtherMessage()
    {
        OtherMessageUI messageUI = Instantiate(_otherMessagePrefab, _messagesParent);
        return messageUI;
    }
}