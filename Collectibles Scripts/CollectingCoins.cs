using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingCoins : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "coin") // checking for collision with the coin
        {
            Destroy(collision.gameObject); // destroying the coin
        }
    }
}