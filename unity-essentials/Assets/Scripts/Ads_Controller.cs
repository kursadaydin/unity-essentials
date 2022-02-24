using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class Ads_Controller : MonoBehaviour
{
    public bool TestMode = true;

    public string androidID = "4629662";
    public string IOSID = "4629663";

    private string rewardedID = "Rewarded_Android";
    private string bannerID = "Banner_Android";
    private string interstatialID = "Interstitial_Android";


    void start()
    {
#if UNITY_ANDROID
        Advertisement.Initialize(androidID, TestMode);
#else
        Advertisement.Initialize(IOSID, TestMode);
#endif

        showRewardedVideo();

    }

    public void showRewardedVideo()
    {

        Advertisement.Show(rewardedID);

    }

    public void showInterstatialVideo()
    {

        Advertisement.Show(interstatialID);

    }

    IEnumerator showBannerWhenReady()
    {

        
           yield return new WaitForSeconds(0.5f);

        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
        Advertisement.Banner.Show(bannerID);
    }
    

}