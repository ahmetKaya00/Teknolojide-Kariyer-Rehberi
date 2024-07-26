using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Takip : MonoBehaviour
{
    public Transform Player;
    void Update()
    {
        if(Player.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, Player.position.y, transform.position.z);
        }
        if (Player.position.y < transform.position.y - 5f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
