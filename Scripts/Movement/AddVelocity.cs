using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddVelocity : MonoBehaviour
{
    // declare all variables
    float speed = 20f; // speed with which the object would move. It is set to 20 meters
    Rigidbody rb; // to store the rigidbody component of the gameobject

    // Start is called before the first frame update
    void Start()
    {
        // store the rigidbody component in rb
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // move the object in the forward direction if space key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
           rb.velocity = Vector3.forward * speed;
        }
        
    }
}
