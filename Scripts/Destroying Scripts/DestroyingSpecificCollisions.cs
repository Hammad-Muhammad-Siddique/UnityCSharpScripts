using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyingSpecificCollisions : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // checks for colliding object's tag. Destroys the player if the object is an enemy
        if (collision.gameObject.tag == "ememy")
        {
            Destroy(gameObject);
        }
    }
}