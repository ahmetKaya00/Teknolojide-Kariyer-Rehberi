using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class example : MonoBehaviour
{
    int score = 10;
    float speed = 5.5f;
    string playerName = "Ahmet";
    bool isGameOver = false;
    void Start()
    {
        Debug.Log("Bootcamp Baþladý!");

        //Tam sayý (integer) tipi     
        Debug.Log("Score: " + score);
        //Ondalýk sayý (float) tipi       
        Debug.Log("Speed: " + speed);
        //Metin (String) tipi       
        Debug.Log("Player Name: " + playerName);
        //Boolean (bool) tipi     
        Debug.Log("Is Game Over: " + isGameOver);

        int a = 10;
        int b = 5;

        int sum = a + b;
        Debug.Log("Sum: " + sum);

        bool isEqual = (a == b);
        Debug.Log("is equal: " + isEqual);

        bool isNotEqual = (a != b);
        Debug.Log("is not equal: " + isNotEqual);
        
        bool isGreaterThan = (a > b);
        Debug.Log("is Greater Than: " + isGreaterThan);

        bool isSunny = true;
        bool isWeekend = false;

        bool gotoBeach = isSunny && isWeekend;
        Debug.Log("Go to Beach: " + gotoBeach);

        bool stayHome = !isSunny || !isWeekend;
        Debug.Log("Stay Home: " + stayHome);
    }

    void Update()
    {
        
    }
}
