using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public void Basla()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }
}
