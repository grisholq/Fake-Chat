using UnityEngine;
using UnityEngine.Video;

public class VideoCharacterInitializer : MonoBehaviour
{
    [SerializeField] private VideoPlayer _player;

    private void OnEnable()
    {
        InitializeVideo();
    }

    private void InitializeVideo()
    {
        _player.clip = Characters.Instance.ChoosenCharacter.VideoAnwser;
    }
}