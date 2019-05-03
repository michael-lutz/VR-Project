using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleVR;

public class CameraAngles : MonoBehaviour
{
    // Created by Michael Lutz

    // Note that I made this Script to work with the First Person Controller Script 
    // to tell it when to jump. It uses the phone's accelerometer to tell wheter
    // the phone is facing either down or up, then changes lookingUp to jump.

    public double lookingThresholdDown;
    public double lookingThresholdUp;
    public bool lookingUp;

    // Start Function
    void Start()
    {
        transform.eulerAngles = new Vector3(0, 0, 0);
    }

    // Update Function
    void Update()
    {
        if (Input.acceleration.y > lookingThresholdUp) // tests to see if the phone is facing the position to jump
        {
            lookingUp = true;
        }
        else
        {
            lookingUp = false;
        }
    }
}
