using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControllers : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip soundClip;
    private Transform kamera;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = soundClip;
        kamera = Camera.main.transform;
    }

    void Update()
    {
        float mesafe = Vector3.Distance(transform.position, kamera.position); 
        float maxMesafe = 10f;
        float normalizedMesafe = Mathf.Clamp01(mesafe / maxMesafe);
        audioSource.volume = 1f - normalizedMesafe;
    }
}
