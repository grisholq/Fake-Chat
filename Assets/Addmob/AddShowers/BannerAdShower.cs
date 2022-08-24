using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class BannerAdShower : Singleton<BannerAdShower>
{
    [SerializeField] private string _adKey;

    private BannerView _adBanner;

    private void Start()
    {
        PrepareBanner();
    }

    public void PrepareBanner()
    {
        AdSize size = AdSize.GetCurrentOrientationAnchoredAdaptiveBannerAdSizeWithWidth(AdSize.FullWidth);

        _adBanner = new BannerView(_adKey, size, AdPosition.Bottom);
        AdRequest adRequest = new AdRequest.Builder().Build();
        _adBanner.LoadAd(adRequest);
        _adBanner.Hide();
    }

    public void ShowBanner()
    {
        _adBanner.Show();
    }  
    
    public void HideBanner()
    {
        _adBanner.Hide();
    }
}