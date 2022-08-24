using TMPro;
using UnityEngine;

public class ViewersCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _viewersDisplay;

    [SerializeField] private int _startViewers;
    [SerializeField] private int _maxViewers;
    [SerializeField] private int _maxRandomViewers;

    private float _viewersAmount;

    private float _timeCounter = 0;

    private void OnEnable()
    {
        SetViewersAmount(_startViewers);
        _timeCounter = 0;
    }

    private void Update()
    {
        TickTimer();

        if (MaxViewersReached() == false && TimerPassed())
        {
            AddViewers();
            DisplayViewers();
            ResetTimer();
        }   
    }

    private bool MaxViewersReached()
    {
        return _viewersAmount >= _maxViewers;
    }

    private void AddViewers()
    {
        _viewersAmount += Random.Range(0, _maxRandomViewers);
    }
    
    private void SetViewersAmount(int amount)
    {
        _viewersAmount = amount;
    }

    private void DisplayViewers()
    {
        _viewersDisplay.text = ((int)_viewersAmount).ToString();
    }

    private void TickTimer()
    {
        _timeCounter += Time.deltaTime;
    }

    private void ResetTimer()
    {
        _timeCounter = 0;
    }

    private bool TimerPassed()
    {
        return _timeCounter >= 1;
    }
}