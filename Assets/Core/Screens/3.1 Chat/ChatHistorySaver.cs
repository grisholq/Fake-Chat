using UnityEngine;

public class ChatHistorySaver : MonoBehaviour
{
    public void AddMessageToCharacterHistory(ChatMessage message)
    {
        Character choosen = Characters.Instance.ChoosenCharacter;
        choosen.MessagesHistory.Add(message.Id);
    }
}
