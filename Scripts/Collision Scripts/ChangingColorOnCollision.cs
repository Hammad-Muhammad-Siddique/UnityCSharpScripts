using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingColorOnCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // the renderer component of the gameobject is accessed. It's color is then changed to red
        GetComponent<Renderer>().material.color = Color.red;
    }
}