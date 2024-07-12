using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            audioSource.Play();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            audioSource.Pause();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            audioSource.Stop();
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            audioSource.PlayOneShot(audioSource.clip);
        }
    }
}
