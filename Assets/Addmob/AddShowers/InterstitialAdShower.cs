using GoogleMobileAds.Api;
using UnityEngine;

public class InterstitialAdShower : Singleton<InterstitialAdShower>
{
    [SerializeField] private string _adKey;

    private InterstitialAd _interstitialAd;

    private void Start()
    {
        LoadAd();
    }

    private void OnApplicationQuit()
    {
        _interstitialAd.Destroy();
    }

    public void LoadAd()
    {
        _interstitialAd = new InterstitialAd(_adKey);
        AdRequest adRequest = new AdRequest.Builder().Build();
        _interstitialAd.LoadAd(adRequest);
    }

    public void ShowAd()
    {
        if(_interstitialAd.IsLoaded())
        {
            _interstitialAd.Show();
            LoadAd();
        }
    }
}