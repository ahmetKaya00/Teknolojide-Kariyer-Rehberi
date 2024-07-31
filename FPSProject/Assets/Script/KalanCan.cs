using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KalanCan : MonoBehaviour
{
    public static int OyuncuCan = 10;
    public int icCan;
    public GameObject kalanCanText;

    private void Update()
    {
        icCan = OyuncuCan;
        kalanCanText.GetComponent<Text>().text = "Kalan Can: " + icCan;

        if(icCan == 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}
