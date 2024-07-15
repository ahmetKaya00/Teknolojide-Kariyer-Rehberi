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
        //        Debug.Log("Ekranýn soluna dokundu!");
        //    }
        //    else
        //    {
        //        Debug.Log("Ekranýn saðýna dokundu!");
        //    }

              if(touch.phase == TouchPhase.Began)
            {
                Debug.Log("Dokunma Baþladý");

                if(touchPosition.x > Screen.width * 0.75f)
                {
                    Debug.Log("Ekranýn saðýna dokundu!");
                }
                else if(touchPosition.x < Screen.width * 0.25f)
                {
                    Debug.Log("Ekranýn soluna dokundu!");
                }
                else if(touchPosition.y > Screen.width * 0.75f)
                {
                    Debug.Log("Ekranýn üstüne dokundu!");
                }
                else if(touchPosition.y < Screen.width * 0.25f)
                {
                    Debug.Log("Ekranýn altýna dokundu!");
                }
            }
              else if(touch.phase == TouchPhase.Moved)
            {
                Debug.Log("Dokunma Hareket Ettirildi!");

                if(touch.deltaPosition.x > 0)
                {
                    Debug.Log("Saða sürükleniyor");
                }
                else if(touch.deltaPosition.x < 0)
                {
                    Debug.Log("Sola sürükleniyor");
                }
                else if(touch.deltaPosition.y > 0)
                {
                    Debug.Log("Yukarý sürükleniyor");
                }
                else if(touch.deltaPosition.y < 0)
                {
                    Debug.Log("Aþaðý sürükleniyor");
                }
            }
              else if(touch.phase == TouchPhase.Ended)
            {
                Debug.Log("Dokunma Bitti!");
            }
        }
    }
}
