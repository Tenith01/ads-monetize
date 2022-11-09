using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour
{
#if UNITY_IOS
    private string gameId = "5012673";
#else
    private string gameId = "5012673";
#endif
    private string video = "Interstitial_Android";
    private string rewardvideo = "Rewarded_Android";

    void Start()
    {
        // Advertisement.AddListener(this);
        Advertisement.Initialize("5012673");
    }

    public void PlayAd()
    {
        if (Advertisement.IsReady(video))
        {
            Advertisement.Show(video);
        }
    }
    public void PlayRewardedAd()
    {
        
    }
}