using GoogleMobileAds.Api;
using UnityEngine;
using UnityEngine.Events;

public class WatchAddButton : MonoBehaviour
{
    public UnityEvent RewardEarned;

    public void WatchRewardedAdd()
    {
        RewardedAd ad = RewardAdShower.Instance.ShowAd();
        ad.OnUserEarnedReward += EarnReward;
    }

    private void EarnReward(object sender, Reward e)
    {
        RewardEarned.Invoke();
    }
}
