using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class RewardAdShower : Singleton<RewardAdShower>
{
    [SerializeField] private string _adKey;

    private RewardedAd _loadingAdd;
    private RewardedAd _showingAdd;

    private void Start()
    {
        LoadAd();
    }

    public void LoadAd()
    {
        _loadingAdd =  new RewardedAd(_adKey);
        AdRequest adRequest = new AdRequest.Builder().Build();
        _loadingAdd.LoadAd(adRequest);
    }

    public RewardedAd ShowAd()
    {
        if (_loadingAdd.IsLoaded())
        {
            _loadingAdd.Show();
            _showingAdd = _loadingAdd;
            LoadAd();
            return _showingAdd;
            
        }

        return _showingAdd;
    }
}
