using UnityEngine;

public class InterstitialAdOnDisableActivator : MonoBehaviour
{
    private void OnDisable()
    {
        InterstitialAdCounter.Instance.Switch();

        if(InterstitialAdCounter.Instance.CanShowAd)
        {
            InterstitialAdShower.Instance.ShowAd();
        }
    }
}