using UnityEngine;
using UnityEngine.UI;

public class FrontCameraDisplay : MonoBehaviour
{ 
    [SerializeField] private RawImage display;
    [SerializeField] private AspectRatioFitter fitter;
    [SerializeField] private float zoom;

    private WebCamTexture _camera;

    private void OnEnable()
    {
        FrontalCamera.Instance.Play();
        _camera = FrontalCamera.Instance.Camera;
        display.texture = _camera;
    }
    
    private void OnDisable()
    {
        FrontalCamera.Instance.Stop();
    }

    private void Update()
    {
        float ratio = (float)_camera.width / (float)_camera.height;
        fitter.aspectRatio = ratio;

        float scaleY = _camera.videoVerticallyMirrored ? -1 : 1;
        display.rectTransform.localScale = new Vector3(1, -1, 1);

        int orient = -_camera.videoRotationAngle;
        display.rectTransform.eulerAngles = new Vector3(0, 0, orient);

        float zoomHeight = Screen.height / display.rectTransform.rect.height * zoom;
        float zoomWidth = Screen.width / display.rectTransform.rect.width * zoom;

        Vector3 scale = display.rectTransform.localScale;
        display.rectTransform.localScale = new Vector3(scale.x * zoom, scale.y * zoom, scale.z);
    }
}
