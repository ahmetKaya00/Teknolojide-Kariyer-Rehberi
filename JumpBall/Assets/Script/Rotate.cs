using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float DonmeHizi = 100f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0f, 0f, DonmeHizi * Time.deltaTime);
    }
}
