using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollows : MonoBehaviour
{
    [SerializeField] GameObject car;

    // Update is called once per frame
    void Update()
    {
        transform.position = car.transform.position + new Vector3(0, 0, -10);
    }
}
