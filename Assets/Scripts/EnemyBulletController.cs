using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletController : MonoBehaviour
{

    private Transform bullet;
    public float speed;

    void Start()
    {
        bullet = GetComponent<Transform>();
    }

    private void FixedUpdate()
    {
        bullet.position += Vector3.up * -speed;

        if (bullet.position.y <= -10)
        {
            Destroy(bullet.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            GameOver.playerHealth--;
            PlayerHealth.playerHealth--;
            if (PlayerHealth.playerHealth == 0)
            {
                Destroy(other.gameObject);
            }
        }
        else if (other.tag == "Base")
        {
            GameObject playerBase = other.gameObject;
            BaseHealth baseHealth = playerBase.GetComponent<BaseHealth>();
            baseHealth.health -= 1;
            Destroy(gameObject);
        }
         
    }
}
