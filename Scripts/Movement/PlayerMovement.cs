using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // declaring all variables
    public float x; // for the x-axis
    public float y = 0; // for the y-axis. Is set to 0 as no movement needed in the y-axis
    public float z; // for the z-axis
    float speed = 20; // speed of the gameobject
    Rigidbody rb; // to store the rigidbody component

    // Start is called before the first frame update
    void Start()
    {
        // storing the rigidbody component in the rb variable
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // getting a value for the x-axis
        x = Input.GetAxis("Horizontal");

        // getting a value for the y-axis
        z = Input.GetAxis("Vertical");

        // implementing player movement
        rb.AddForce(x * speed, y, z * speed);
        
    }
}