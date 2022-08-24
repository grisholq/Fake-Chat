using UnityEngine;

public class InterstitialAdCounter : Singleton<InterstitialAdCounter>
{
    public bool CanShowAd { get; private set; }

    private void Awake()
    {
        CanShowAd = true;
    }

    public void Switch()
    {
        CanShowAd = !CanShowAd;
    }
}