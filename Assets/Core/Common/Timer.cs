using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] protected TextMeshProUGUI _timeDisplay;

    protected float _time = 0;

    private void OnEnable()
    {
        _time = 0;
    }

    private void Update()
    {
        TimeTick();
        UpdateDisplay();
    }

    private void TimeTick()
    {
        _time += Time.deltaTime;
    }

    public virtual void UpdateDisplay()
    {
        int minutes;
        int seconds;

        minutes = (int) (_time / 60f);
        seconds = (int)(_time - minutes * 60);

        
        ClearDisplay();
        UpdateMinutes(minutes);
        UpdateSeconds(seconds);
    }

    protected void ClearDisplay()
    {
        _timeDisplay.text = "";
    }

    protected void UpdateMinutes(int minutes)
    {
        if(minutes < 10)
        {
            _timeDisplay.text += '0' + minutes.ToString() + ':';
        }
        else
        {
            _timeDisplay.text += minutes.ToString() + ':';
        }
    }

    protected void UpdateSeconds(int seconds)
    {
        if (seconds < 10)
        {
            _timeDisplay.text += '0' + seconds.ToString();
        }
        else
        {
            _timeDisplay.text += seconds.ToString();
        }
    }
}