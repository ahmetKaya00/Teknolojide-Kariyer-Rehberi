using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilahAl : MonoBehaviour
{
    public float Mesafe = OyuncuDokumantasyon.HedefMesafe;
    public GameObject yazi, anaSilah, YedekSilah, cephane;
    public AudioSource almaSesi;

    private void Start()
    {
        yazi.SetActive(false);
        anaSilah.SetActive(false);
        cephane.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetButtonDown("Pick"))
        {
            if (Mesafe <= 3)
            {
                SilahAlindi();
            }
        }
    }

    private void SilahAlindi()
    {
        almaSesi.Play();
        transform.position = new Vector3(0, -50, 0);
        YedekSilah.SetActive (true);
        anaSilah.SetActive (true);
        cephane.SetActive (true);
        yazi.SetActive (true);
    }
}
