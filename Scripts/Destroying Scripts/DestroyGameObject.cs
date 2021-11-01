using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // destroys the gameobject to which this script is attached as the game starts
        Destroy(gameObject); 
    }
}
