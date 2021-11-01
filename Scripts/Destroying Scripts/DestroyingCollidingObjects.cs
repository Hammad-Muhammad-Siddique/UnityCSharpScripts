using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyingCollidingObjects : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // destroys anything that collides with the gameobject.
        Destroy(collision.gameObject);
    }
}
