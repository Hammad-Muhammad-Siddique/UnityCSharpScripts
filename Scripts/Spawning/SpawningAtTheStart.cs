using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject ball; // the object which will be spawned
    public Transform spawnPoint; // the position where the ball will spawn

    // Start is called before the first frame update
    void Start()
    {
        // spawning the ball at the start of the ganme
        spawnBall();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // a new function to spawn the ball
    void spawnBall()
    {
        // the ball is instantiated at the position of the spawnPoint
        Instantiate(ball, spawnPoint.position, Quaternion.identity);
    }
}
