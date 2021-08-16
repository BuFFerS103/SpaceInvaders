using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    private Transform enemyHolder;
    public float speed;
    public Text winText;
    public static float enemyHealth = 1;

    void Start()
    {
        winText.enabled = false;
        InvokeRepeating("Moving", 0.1f, 0.3f);
        enemyHolder = GetComponent<Transform>();
    }

    private void Moving()
    {
        enemyHolder.position += Vector3.right * speed;

        foreach (Transform enemy in enemyHolder)
        {
            if (enemy.position.x < -10 || enemy.position.x > 10)
            {
                speed = -speed;
                enemyHolder.position += Vector3.down * 0.5f;
                return;
            }

            if (enemy.position.y <= -4)
            {
                GameOver.playerHealth = 0;
                Time.timeScale = 0;
            }
        }

        if (enemyHolder.childCount == 1)
        {
            CancelInvoke();
            InvokeRepeating("Moving", 0.1f, 0.25f);
        }

        if (enemyHolder.childCount == 0)
        {
            winText.enabled = true;
        }
    }
}
