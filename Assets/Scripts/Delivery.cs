using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPacage;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Bump with " + collision.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Pacage" && !hasPacage)
        {
            Debug.Log("We got a pacage!");
            hasPacage = true;
        }
        else if (collision.tag == "Customer" && hasPacage)
        {
            Debug.Log("Pacage has delivered!");
            hasPacage = false;
        }
        /*else
        {
            Debug.Log("We triggered with " + collision.gameObject);
        }*/
    }
}
