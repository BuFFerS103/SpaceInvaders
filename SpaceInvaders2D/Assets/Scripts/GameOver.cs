using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public static byte playerHealth = 5;
    private Text gameOver;

    void Start()
    {
        gameOver = GetComponent<Text>();
        gameOver.enabled = false;
    }

    void Update()
    {
        if (playerHealth <= 0)
        {
            Time.timeScale = 0;
            gameOver.enabled = true;
        }
    }
}
