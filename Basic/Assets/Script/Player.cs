
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private string playerName;
    private int playerScore;
    

    public string GetPlayerName()
    {
        return playerName; 
    }

    public void SetPlayerName(string name)
    {
        if (!string.IsNullOrEmpty(name))
        {
            playerName = name;
        }
        else
        {
            Debug.LogError("Player name cannot be empty");
        }
    }

    public int GetPlayerScore() { 
        
        return playerScore;

    }

    public void SetPlayerScore(int score) { 
    
        if(score >= 0)
        {
            playerScore = score;
        }
        else
        {
            Debug.LogError("Player score cannot be nagative");
        }
    }
}
