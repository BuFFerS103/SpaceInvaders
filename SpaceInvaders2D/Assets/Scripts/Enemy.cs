using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform enemyPos;
    public float points = 10;
    public float health = 1;
    public GameObject shot;
    public float fireRate = 0.9999f;
    public Transform obs;

    void Start()
    {
        enemyPos = GetComponent<Transform>();
    }

    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
            PlayerScore.playerScore += points;
        }

        if (transform.position.y <= obs.position.y)
        {
            if (Random.value > fireRate)
            {
                Instantiate(shot, enemyPos.position, enemyPos.rotation);
            }
        }
    }
}
