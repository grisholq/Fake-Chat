using UnityEngine;
using UnityEngine.Video;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Character", menuName = "Character")]
public class Character : ScriptableObject
{
    public string Name;
    public string Number;

    public Texture ProfilePicture;

    public bool IsChoosen;
    public bool IsUnlocked;
    public int AdsToOpen;
    public int WatchedAdds;

    public AudioClip CallAnwser;
    public VideoClip VideoAnwser;

    public List<int> MessagesHistory;
    public ChatMessage[] ChatMessages;
    public LiveMessage[] LiveMessages;
}