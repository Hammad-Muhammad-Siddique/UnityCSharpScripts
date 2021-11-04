using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // declare all variables
    public Transform target; // the gameobject at which the camera will look

    // Update is called once per frame
    void Update()
    {
        // look at the target
        transform.LookAt(target);
    }
}