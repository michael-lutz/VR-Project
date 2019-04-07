using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleVR;

public class CameraAngles : MonoBehaviour {


    /*new Vector3 cameraAngle;
    private double cameraVertValue;*/
    public double lookingThresholdDown;
    public double lookingThresholdUp;

    //private double angle;

    public bool lookingUp;

    //private double accelerating;
    //public Transform target;

    //private Quaternion quaternion = new Quaternion(0f, 0f, 0f, 1f);

    //private Vector3 rotationVector;


    // Use this for initialization
    void Start () {
        //rotationVector = transform.
        transform.eulerAngles = new Vector3(0, 0, 0);
    }
	
	// Update is called once per frame
	void Update () {

        //new Vector3 target = new Quaternion (1, 1, 1, 1);
        //Debug.Log(transform.eulerAngles);
        /*cameraAngle = transform.eulerAngles;
        cameraVertValue = cameraAngle.x;*/
        //quaternion = transform.rotation;

        //Vector3 angles = quaternion.eulerAngles;
        //Debug.Log(angles);

        //Debug.Log(angle);


        //Debug.Log(Input.acceleration.y);
        
        /*if (transform.localEulerAngles.x > lookingThresholdDown && transform.localEulerAngles.x < 90)
        {
            Debug.Log("Looking Down (add function later)");

        }

        if (transform.eulerAngles.x < lookingThresholdUp && transform.eulerAngles.x > 270)
        {
            //Debug.Log("Looking Up");
            lookingUp = true;
        }
        else
        {
            lookingUp = false;
        }*/

        /*if (transform.eulerAngles.x > 5 && transform.eulerAngles.x < 15)
        {
            lookingUp = true;
        }
        else
        {
            lookingUp = false;
        }*/

        if (Input.acceleration.y > lookingThresholdUp)
        {
            lookingUp = true;
        }
        else
        {
            lookingUp = false;
        }

        /*if (transform.localEulerAngles.x < lookingThresholdUp)
        {
            //Debug.Log("Looking Up");
            lookingUp = true;
        }
        else
        {
            lookingUp = false;
        }*/


    }
}
