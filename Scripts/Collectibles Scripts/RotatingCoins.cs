using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingCoins : MonoBehaviour
{
    public float rotateSpeed; // the speed of rotation

    // Start is called before the first frame update
    private void FixedUpdate()
    {
        transform.Rotate(Vector3.up, rotateSpeed); // rotating the coin in the upward direction
    }
}