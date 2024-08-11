using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CollisionHandler : MonoBehaviour
{
    private Ads _ads;
    public GameObject panel;
    public Button contiuneButton, restartButton;

    private void Start()
    {
        _ads = FindObjectOfType<Ads>();
        panel.SetActive(false);

        contiuneButton.onClick.AddListener(OnContinueButtonCliked);
        restartButton.onClick.AddListener(OnRestartButtonCliked);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            _ads.ShowInterstitialAd();
            panel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    private void OnContinueButtonCliked()
    {
        panel.SetActive(false);
        Time.timeScale = 1.0f;
        _ads.ShowRewerdedAd();
    }

    private void OnRestartButtonCliked()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
