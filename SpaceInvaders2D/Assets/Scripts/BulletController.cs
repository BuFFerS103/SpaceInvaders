using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Transform bullet;
    public float speed;

    void Start()
    {
        bullet = GetComponent<Transform>();
    }

    private void FixedUpdate()
    {
        bullet.position += Vector3.up * speed;

        if (bullet.position.y >= 10)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            GameObject enemy = other.gameObject;
            Enemy enemyHP = enemy.GetComponent<Enemy>();
            enemyHP.health -= 1;
            Destroy(gameObject);
        }
        
        else if (other.tag == "Base")
        {
            Destroy(gameObject); 
        }
    }
}
