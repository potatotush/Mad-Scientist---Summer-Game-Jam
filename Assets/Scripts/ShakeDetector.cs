using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShakeDetector : Singleton<ShakeDetector>
{
    float mouseSpeed;
    public float maxSpeed = 0;
    public float barDegradeAmount = 1;

    float barValue = 0;

    public Slider slider;

    void Update()
    {
        mouseSpeed = Mathf.Sqrt((Input.GetAxis("Mouse X") * Input.GetAxis("Mouse X")) + (Input.GetAxis("Mouse Y") * Input.GetAxis("Mouse Y")));
        /*
        //detector (3 is quite fast, 1 is quite stable)
        if (maxSpeed < mouseSpeed)
        {
            maxSpeed = mouseSpeed;
        }
        */

        barValue += mouseSpeed;
        barValue -= barDegradeAmount;

        if (barValue < 0)
        {
            barValue = 0;
        }
        else if (barValue > 100)
        {
            barValue = 100;
        }

        slider.value = barValue;
    }
}
