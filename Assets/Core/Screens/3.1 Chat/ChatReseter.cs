using UnityEngine;
using UnityEngine.Events;

public class ChatReseter : MonoBehaviour
{
    public UnityEvent ChatReset;

    public void ResetChat()
    {
        Characters.Instance.ResetChoosenCharacterChat();
        ChatReset.Invoke();
    }
}
