using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWhat : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Bump with " + collision.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("We triggered with " + collision.gameObject);
    }
}
