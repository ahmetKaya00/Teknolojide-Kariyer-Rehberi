using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ads : MonoBehaviour
{
    private string _adUnityBnnr = "ca-app-pub-3940256099942544/6300978111";
    private string _adUnitGcs = "ca-app-pub-3940256099942544/1033173712";
    private string _adUnitOdl = "ca-app-pub-3940256099942544/5224354917";

    BannerView _bannerView;
    InterstitialAd _InterstitialAd;
    RewardedAd _rewardedAd;
    public void Start()
    {
        MobileAds.Initialize(initStatus => { LoadAd(); LoadInterstialAd(); LoadRewerdedAd(); });
    }

    public void LoadAd()
    {
        if(_bannerView == null)
        {
            CreateBannerView();
        }
        var adRequest = new AdRequest();
        Debug.Log("Banner reklam yükleniyor");
        _bannerView.LoadAd(adRequest);
    }

    public void CreateBannerView()
    {
        Debug.Log("Banner görüntü oluþturuluyor..");
        if(_bannerView != null)
        {
            DestroyAd();
        }
        _bannerView = new BannerView(_adUnityBnnr, AdSize.Banner, AdPosition.Bottom);
    }

    public void DestroyAd()
    {
        if (_bannerView != null)
        {
            _bannerView.Destroy();
            _bannerView = null;
        }
    }

    public void LoadInterstialAd()
    {
        if(_InterstitialAd != null)
        {
            _InterstitialAd.Destroy();
            _InterstitialAd = null;
        }

        var adRequest = new AdRequest();

        InterstitialAd.Load(_adUnitGcs,adRequest,(InterstitialAd ad, LoadAdError error) =>
        {
            if(error != null || ad == null)
            {
                Debug.Log("Geçiþ reklamý oluþturulurken hata oluþtu:" + error);
                return;
            }
            _InterstitialAd = ad;
        });
    }
    public void ShowInterstitialAd()
    {
        if( _InterstitialAd != null && _InterstitialAd.CanShowAd())
        {
            _InterstitialAd.Show();
        }
        else
        {
            Debug.Log("Geçiþ reklamý hazýr deðil");
        }
    }
    public void LoadRewerdedAd()
    {
        if (_rewardedAd != null)
        {
            _rewardedAd.Destroy();
            _rewardedAd = null;
        }

        var adRequest = new AdRequest();

        RewardedAd.Load(_adUnitOdl, adRequest, (RewardedAd ad, LoadAdError error) =>
        {
            if (error != null || ad == null)
            {
                Debug.Log("Ödüllü reklamý oluþturulurken hata oluþtu:" + error);
                return;
            }
            _rewardedAd = ad;
        });
    }

    public void ShowRewerdedAd()
    {
        const string rewerdMsg = "Ödüllü reklam kullanýcýya gönderildi. Tür: {0}, miktar: {1}";

        if (_rewardedAd != null && _rewardedAd.CanShowAd())
        {
            _rewardedAd.Show((Reward reward) =>
            {
                Debug.Log(string.Format(rewerdMsg, reward.Type, reward.Amount));
            });
        }
        else {
            Debug.Log("Ödüllü reklam hazýr deðil!");
        }
    }

}
