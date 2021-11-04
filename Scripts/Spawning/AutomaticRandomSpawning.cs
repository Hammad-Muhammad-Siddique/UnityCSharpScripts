using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticRandomSpawning : MonoBehaviour
{
    // declare all variables
    public GameObject ball; // the object to spawn
    public float maxX; // the x coordinate to spawn the object at
    public float maxZ; // the z coordinate to spawn the object at
    float RandomX; // random X postion
    float RandomZ; // random Z position
    float yPosition = 10f; // Y position

    // Start is called before the first frame update
    void Start()
    {
        // spawning the ball repeatedly
        InvokeRepeating("SpawnBall", 1f, 2f);
    }

    void SpawnBall()
    {
        // a random position for x
        RandomX = Random.Range(-maxX, maxX);

        // a ramdom position for z
        RandomZ = Random.Range(-maxZ, maxZ);

        // creating a variable for random position
        Vector3 randomSpawnPositon = new Vector3(RandomX, yPosition, RandomZ);

        // spawning the ball
        Instantiate(ball, randomSpawnPositon, Quaternion.identity);
    }
}