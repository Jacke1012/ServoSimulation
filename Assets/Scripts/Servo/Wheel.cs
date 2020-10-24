using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    new WheelCollider collider;
    //Rigidbody rb;
    Servo servo;

    private void Awake()
    {
        collider = GetComponent<WheelCollider>();
        //rb = GetComponent<Rigidbody>();
        servo = GetComponentInParent<Body>().servo;
    }

    public void Turn(int angle)
    {
        //rb.AddTorque(transform.right * angle * servo.forceMultiplyer);
        collider.motorTorque = angle * servo.forceMultiplyer;
    }

}
