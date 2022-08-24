using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChatEvents : MonoBehaviour
{
    public UnityEvent<ChatMessage> SuggestionPressed;
    public UnityEvent TypingEnded;

    public void CallSuggestionPressed(ChatMessage message)
    {
        SuggestionPressed.Invoke(message);
    }

    public void CallTypingEnded()
    {
        TypingEnded.Invoke();
    }
}