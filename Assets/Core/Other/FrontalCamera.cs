using UnityEngine;
using UnityEngine.UI;

public class FrontalCamera : Singleton<FrontalCamera>
{
    public WebCamTexture Camera { get; set; }

    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;

        foreach (var device in devices)
        {
            if (device.isFrontFacing)
            {
                Camera = new WebCamTexture(device.name, (int)Screen.width, (int)Screen.height, 60);
                break;
            }
        }
    }

    public void Play()
    {
        if (Camera != null)
            Camera.Play();
    }

    public void Stop()
    {
        if (Camera != null)
            Camera.Stop();
    }
}
