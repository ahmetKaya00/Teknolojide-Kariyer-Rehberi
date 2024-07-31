using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [Header("Lovel To Load")]
    public string _newGameLevel;

    [Header("Volume Settings")]
    [SerializeField] private TMP_Text _volumeText = null;
    [SerializeField] private Slider volumeSlider = null;
    [SerializeField] private float defaultVolume = 1.0f;

    [Header("Confirmation")]
    [SerializeField] private GameObject confirmationPrompt = null;

    private void Start()
    {
        volumeSlider.onValueChanged.AddListener(SetVolume);
        SetVolume(defaultVolume);
    }

    public void SetVolume(float volume)
    {
        AudioListener.volume = volume;
        _volumeText.text = volume.ToString("0.0");
    }

    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Exit");
    }
    public void VolumeApply()
    {
        PlayerPrefs.SetFloat("masterVolume", AudioListener.volume);
        StartCoroutine(ConfirmationBox());
    }
    public void ResetButton(string menuType)
    {
        if(menuType == "Audio")
        {
            AudioListener.volume = defaultVolume;
            volumeSlider.value = defaultVolume;
            _volumeText.text = defaultVolume.ToString("0.0");
            VolumeApply();
        }
    }
    public IEnumerator ConfirmationBox()
    {
        confirmationPrompt.SetActive(true);
        yield return new WaitForSeconds(2);
        confirmationPrompt.SetActive(false);
    }
    public void NewGameDialogYes()
    {
        SceneManager.LoadScene(_newGameLevel);
    }
}
