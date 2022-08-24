using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LiveStreamMessageUI : MonoBehaviour
{
    [SerializeField] private RawImage _profilePicture;
    [SerializeField] private TextMeshProUGUI _name;
    [SerializeField] private TextMeshProUGUI _message;

    public void PrepareMessage(Character character)
    {
        _profilePicture.texture = character.ProfilePicture;
        _name.text = character.Name;
        _message.text = GetRandomCharacterLiveMessage(character);
    }

    private string GetRandomCharacterLiveMessage(Character character)
    {
        LiveMessage[] liveMessages = character.LiveMessages;

        int index = Random.Range(0, liveMessages.Length);

        return liveMessages[index].Text;
    }
}
