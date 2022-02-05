using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Bump with " + collision.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Pacage")
        {
            Debug.Log("We got a pacage!");
        }
        else if (collision.tag == "Customer")
        {
            Debug.Log("Pacage has delivered!");
        }
        else
        {
            Debug.Log("We triggered with " + collision.gameObject);
        }
    }
}
