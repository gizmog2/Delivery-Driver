using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{

    [SerializeField] float rotationSpeed = 0.2f;
    [SerializeField] float driveSpeed = 0.01f;
    [SerializeField] float slowSpeed = 0.1f;
    [SerializeField] float boostSpeed = 0.4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotationAmount = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        float speedAmount = Input.GetAxis("Vertical") * driveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -rotationAmount);
        transform.Translate(0, speedAmount, 0);        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        driveSpeed = slowSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Boost")
        {
            driveSpeed = boostSpeed;
            Destroy(collision.gameObject, 0.2f);
        }        
       
    }

}
