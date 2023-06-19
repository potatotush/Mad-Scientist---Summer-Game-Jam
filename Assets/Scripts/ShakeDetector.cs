using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeDetector : MonoBehaviour
{
    float mouseSpeed;
    public float maxSpeed = 0;

    void Update()
    {
        mouseSpeed = Mathf.Sqrt((Input.GetAxis("Mouse X") * Input.GetAxis("Mouse X")) + (Input.GetAxis("Mouse Y") * Input.GetAxis("Mouse Y")));


        //detector (3 is quite fast, 1 is quite stable)
        if (maxSpeed < mouseSpeed)
        {
            maxSpeed = mouseSpeed;
        }
    }
}
