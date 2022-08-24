using TMPro;
using UnityEngine;

public class LoadProgressPercents : MonoBehaviour
{
    [SerializeField] private float _maxValue;
    [SerializeField] private TextMeshProUGUI _display;

    public void SetProgressValue(float value)
    {
        float percent = value / _maxValue;
        percent *= 100;
        _display.text = ((int)percent).ToString() + '%';
    }
}
