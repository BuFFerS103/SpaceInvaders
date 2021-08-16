using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    private Transform holder;
    public float speed;
    public Text winText;
    public static float enemyHealth = 1;

    void Start()
    {
        winText.enabled = false;
        InvokeRepeating("Moving", 0.1f, 0.3f);
        holder = GetComponent<Transform>();
    }

    private void Moving()
    {
        holder.position += Vector3.right * speed;

        foreach (Transform enemy in holder)
        {
            if (enemy.position.x < -10 || enemy.position.x > 10)
            {
                speed = -speed;
                holder.position += Vector3.down * 0.5f;
                return;
            }

            if (enemy.position.y <= -4)
            {
                GameOver.playerHealth = 0;
                Time.timeScale = 0;
            }
        }

        if (holder.childCount == 1)
        {
            CancelInvoke();
            InvokeRepeating("Moving", 0.1f, 0.25f);
        }

        if (holder.childCount == 0)
        {
            winText.enabled = true;
        }
    }
}
