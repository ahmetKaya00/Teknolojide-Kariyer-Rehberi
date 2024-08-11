using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hareket : MonoBehaviour
{
    public int speed;
    public void sag()
    {
        transform.Translate(speed * Time.deltaTime, 0f, 0f);
    }
    public void sol()
    {
        transform.Translate(speed * Time.deltaTime * -1, 0f, 0f);
    }

    public void OpenURL()
    {
        Application.OpenURL("https://www.techcareer.net/");
    }


    public void sahneGecis(string a)
    {
        SceneManager.LoadScene(a);
    }

}
