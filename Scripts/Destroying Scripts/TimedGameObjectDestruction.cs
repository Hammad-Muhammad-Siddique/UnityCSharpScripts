using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedGameObjectDestruction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // destroys the game object after 3 seconds. Seconds are written after the gameobject keyword.
        Destroy(gameObject,3f);
    }
}
