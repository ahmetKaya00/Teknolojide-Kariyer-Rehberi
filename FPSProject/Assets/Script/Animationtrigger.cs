using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animationtrigger : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && Mermi._cephane > 0)
        {
            AudioSource silahSesi = GetComponent<AudioSource>();
            silahSesi.Play();
            _animator.SetBool("isTrigger", true);
        }
        else
        {
            _animator.SetBool("isTrigger", false);
        }
    }
}
