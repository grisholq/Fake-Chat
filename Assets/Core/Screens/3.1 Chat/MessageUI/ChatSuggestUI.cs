using UnityEngine.UI;
using UnityEngine.Events;

public class ChatSuggestUI : MessageUI
{
    public event UnityAction<ChatMessage> SuggestionMessageSend;

    public Button Button;

    public ChatMessage Message
    { 
        get
        {
            return _message;
        }

        set
        {
            _message = value;
            SetText(_message.Question);
        }
    }

    private ChatMessage _message;

    public void SendSuggestionMessage()
    {
        if (SuggestionMessageSend == null) return;
        SuggestionMessageSend(Message);
    }
}