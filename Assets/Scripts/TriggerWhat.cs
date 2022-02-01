using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWhat : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("We triggered with " + collision.gameObject);
    }
}
