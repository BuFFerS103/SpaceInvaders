using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform currLocation;
    public float points = 10;
    public float health = 1;
    public GameObject shot;
    public float fireRate = 0.9999f;


    void Start()
    {
        currLocation = GetComponent<Transform>();
    }

    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
            PlayerScore.playerScore += points;
            return;
        }

        //if (Physics.Raycast(currLocation.position, Vector2.down, 10) )
        //{
        //    return;
        //}

        if (GameOver.playerHealth <= 0 )
        {
            return;
        }

        if (Random.value > fireRate)
        {
            Instantiate(shot, currLocation.position, currLocation.rotation);
        }


    }
}
