using UnityEngine;
using UnityEngine.UI;

public class AudioCallMicrophone : MonoBehaviour
{
    [SerializeField] private RawImage _stateImage;
    [SerializeField] private Texture2D _turnOnTexture;
    [SerializeField] private Texture2D _turnOffTexture;

    private bool _turnedOn = true;

    private void OnEnable()
    {
        TurnOn();
    }

    public void SwitchMicrophoneState()
    {
        if (_turnedOn)
        {
            TurnOff();
        }
        else
        {
            TurnOn();
        }
    }

    private void TurnOn()
    {
        _turnedOn = true;
        _stateImage.texture = _turnOnTexture;
    }

    private void TurnOff()
    {
        _turnedOn = false;
        _stateImage.texture = _turnOffTexture;
    }
}