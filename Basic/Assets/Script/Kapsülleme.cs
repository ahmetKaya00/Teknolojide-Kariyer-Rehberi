using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kapsülleme : MonoBehaviour
{
    void Start()
    {
        Player player = new Player();

        player.SetPlayerName("Ahmet");
        player.SetPlayerScore(100);

        string name = player.GetPlayerName();
        int score = player.GetPlayerScore();

        Debug.Log("Player Name: " + name);
        Debug.Log("Player Score: " + score);

        
    }

    
}
