using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GameOver.playerHealth = 5;
            PlayerScore.playerScore = 0;
            Time.timeScale = 1;
            SceneManager.LoadScene("Scene_001");
        }
    }
}
