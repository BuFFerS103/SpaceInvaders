using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public static float playerHealth = GameOver.playerHealth;
    private Text healthText;

    void Start()
    {
        healthText = GetComponent<Text>();
    }

    void Update()
    {
        healthText.text = "Lives " + playerHealth;
    }
}
