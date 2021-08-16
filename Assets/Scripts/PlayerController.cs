using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Transform player;
    public float speed;
    public float maxBound, minBound;

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;

    private float nextFire;

    void Start()
    {
        player = GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");

        if (player.position.x < minBound && horizontal < 0)
        {
            horizontal = 0;
        }
        else if (player.position.x > maxBound && horizontal > 0) 
        {
            horizontal = 0;
        }

        player.position += Vector3.right * horizontal * speed;
    }

    private void Update()   
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }
    }

}
