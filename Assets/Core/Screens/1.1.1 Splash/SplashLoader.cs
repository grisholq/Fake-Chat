using UnityEngine;
using UnityEngine.Events;

public class SplashLoader : MonoBehaviour
{
    [SerializeField] private float _loadTime;

    [SerializeField] private UnityEvent<float> _timeChanged;
    [SerializeField] private UnityEvent _loadFinished;

    private float _time = 0;

    private void OnEnable()
    {
        _time = 0;
    }

    void Update()
    {
        LoadTimeTick();
    }

    private void LoadTimeTick()
    {
        _time += Time.deltaTime;
        _timeChanged.Invoke(_time);

        if (_time >= _loadTime)
        {
            _loadFinished.Invoke();
        }
    }
}