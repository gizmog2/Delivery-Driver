using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPacageColor = new Color32(255, 255, 255, 255);
    [SerializeField] Color32 noPacageColor = new Color32(1, 1, 1, 1);
    [SerializeField] float destroyTime;
    bool hasPacage;

    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
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
            spriteRenderer.color = hasPacageColor;
            Destroy(collision.gameObject, destroyTime);
        }
        else if (collision.tag == "Customer" && hasPacage)
        {
            Debug.Log("Pacage has delivered!");
            hasPacage = false;
            spriteRenderer.color = noPacageColor;
        }
        /*else
        {
            Debug.Log("We triggered with " + collision.gameObject);
        }*/
    }
}
