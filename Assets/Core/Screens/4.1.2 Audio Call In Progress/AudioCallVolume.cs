using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class AudioCallVolume : MonoBehaviour
{
    [SerializeField] private RawImage _audioStateImage;

    [SerializeField] private Texture2D _audioStateTexture1;
    [SerializeField] private Texture2D _audioStateTexture2;
    [SerializeField] private Texture2D _audioStateTexture3;
    [SerializeField] private Texture2D _audioStateTexture4;

    [SerializeField] private UnityEvent<float> _volumeLevelChanged;

    private float _currentVolumeLevel = 1;
    private float _maxVolumeLevel = 4;

    private void OnEnable()
    {
        _currentVolumeLevel = 4;
        DisplayVolumeState();
        UpdateVolumeLevel();
    }

    public void SwitchAudioState()
    {
        IncreaseVolumeLevel();
        UpdateVolumeLevel();
        DisplayVolumeState();
    }

    private void IncreaseVolumeLevel()
    {
        _currentVolumeLevel++;
        if (_currentVolumeLevel >= 5) _currentVolumeLevel = 1;
    }

    public void DisplayVolumeState()
    {
        switch (_currentVolumeLevel)
        {
            case 1:
                _audioStateImage.texture = _audioStateTexture1;
                break;

            case 2:
                _audioStateImage.texture = _audioStateTexture2;
                break;

            case 3:
                _audioStateImage.texture = _audioStateTexture3;
                break;

            case 4:
                _audioStateImage.texture = _audioStateTexture4;
                break;

            default:
                break;
        }
    }

    public void UpdateVolumeLevel()
    {
        _volumeLevelChanged.Invoke(_currentVolumeLevel / _maxVolumeLevel);
    }
}