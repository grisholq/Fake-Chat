using UnityEngine;
using UnityEngine.Events;

public class ChatSuggestEvents : MonoBehaviour
{
    public UnityEvent<ChatMessage> SuggestPressed; 

    public void CallSuggestPressedEvent(ChatMessage chatMessage)
    {
        SuggestPressed.Invoke(chatMessage);   
    }
}