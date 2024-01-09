using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SpawnAsteroid : MonoBehaviour
{
    public GameObject Asteroid;
    public float spawnInterval = 0.5f;
    public float timer;
    public Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        rb = Asteroid.GetComponent<Rigidbody2D>();
        timer = timer + Time.deltaTime;
        if (timer >= spawnInterval)
        {
            rb.gravityScale = UnityEngine.Random.Range(0.01f, 2.5f);
            float positionX = UnityEngine.Random.Range(-10.5f, 10.5f);
            Vector2 coordinate = new Vector2(positionX, 8);
            // Instancie un nouvel objet Asteroid au position du SpawnerAsteroid
            Instantiate(Asteroid, coordinate, Quaternion.identity);
            timer = 0;
        }

    }
}

