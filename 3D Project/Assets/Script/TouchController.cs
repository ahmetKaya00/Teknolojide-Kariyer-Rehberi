using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    private void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    Debug.Log("Dokunma Baþladý!");
                    break;
                case TouchPhase.Moved:
                    Debug.Log("Dokunma hareket ettirildi");
                    break;
                case TouchPhase.Ended:
                    Debug.Log("Dokunma Bitti!");
                    break;
            }
        }
    }
}
