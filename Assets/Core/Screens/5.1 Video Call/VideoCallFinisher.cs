using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Video;

public class VideoCallFinisher : MonoBehaviour
{
    [SerializeField] private VideoPlayer _videoPlayer;

    [SerializeField] private UnityEvent _callEnded;

    private void Start()
    {
        _videoPlayer.loopPointReached += EndVideoCall;
    }

    public void EndVideoCall(VideoPlayer source)
    {
        _callEnded.Invoke();
    }
}