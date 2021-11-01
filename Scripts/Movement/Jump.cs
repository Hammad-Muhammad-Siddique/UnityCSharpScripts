using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    // declare all variables
    Rigidbody rb; // variable of type rigidbody to store the rigidbody component of the gameobject
    float jumpPower = 500; // vairable to store the power of the jump

    // Start is called before the first frame update
    void Start()
    {
        // storing the rigidbody component in the rb variable
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // implementing the jump
            rb.AddForce(Vector3.up * jumpPower);
        }
        
    }
}
