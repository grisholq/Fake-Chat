using UnityEngine;
using UnityEngine.UI;

public class LoadProgressBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    public void SetLoadValue(float value)
    {
        _slider.value = value;
    }
}