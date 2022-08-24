using UnityEngine;
using GoogleMobileAds.Api;

public class AdmobInitializer : MonoBehaviour
{
    private void OnEnable()
    {
        Initialize();
    }

    public void Initialize()
    {
        MobileAds.Initialize(initStatus => { }); 
    }
}