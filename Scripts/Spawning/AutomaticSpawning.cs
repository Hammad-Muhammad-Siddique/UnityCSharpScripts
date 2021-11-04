using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticSpawning : MonoBehaviour
{
    // declare all variables
    public GameObject ball; // the object to be spawned
    Transform spawnPoint; // the point where the object will be spawned

    // Start is called before the first frame update
    void Start()
    {
        // repeated spawning the ball
        InvokeRepeating("SpawnBall", 1f, 2f);
    }

    // creating a function for spawning a ball
    void SpawnBall()
    {
        Instantiate(ball,spawnPoint.position, Quaternion.identity);
    }
}