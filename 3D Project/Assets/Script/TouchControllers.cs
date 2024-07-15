using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControllers : MonoBehaviour
{
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = touch.position;

        //   if(touch.phase == TouchPhase.Stationary)
        //   {
        //       Debug.Log("Ulti AT!");
        //   }

        //    if(touchPosition.x < Screen.width / 2)
        //    {
        //        Debug.Log("Ekran�n soluna dokundu!");
        //    }
        //    else
        //    {
        //        Debug.Log("Ekran�n sa��na dokundu!");
        //    }

              if(touch.phase == TouchPhase.Began)
            {
                Debug.Log("Dokunma Ba�lad�");

                if(touchPosition.x > Screen.width * 0.75f)
                {
                    Debug.Log("Ekran�n sa��na dokundu!");
                }
                else if(touchPosition.x < Screen.width * 0.25f)
                {
                    Debug.Log("Ekran�n soluna dokundu!");
                }
                else if(touchPosition.y > Screen.width * 0.75f)
                {
                    Debug.Log("Ekran�n �st�ne dokundu!");
                }
                else if(touchPosition.y < Screen.width * 0.25f)
                {
                    Debug.Log("Ekran�n alt�na dokundu!");
                }
            }
              else if(touch.phase == TouchPhase.Moved)
            {
                Debug.Log("Dokunma Hareket Ettirildi!");

                if(touch.deltaPosition.x > 0)
                {
                    Debug.Log("Sa�a s�r�kleniyor");
                }
                else if(touch.deltaPosition.x < 0)
                {
                    Debug.Log("Sola s�r�kleniyor");
                }
                else if(touch.deltaPosition.y > 0)
                {
                    Debug.Log("Yukar� s�r�kleniyor");
                }
                else if(touch.deltaPosition.y < 0)
                {
                    Debug.Log("A�a�� s�r�kleniyor");
                }
            }
              else if(touch.phase == TouchPhase.Ended)
            {
                Debug.Log("Dokunma Bitti!");
            }
        }
    }
}
