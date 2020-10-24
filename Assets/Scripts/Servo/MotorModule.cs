using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorModule : MonoBehaviour
{
    private Wheel wheel;

    private void Awake()
    {
        wheel = GetComponentInChildren<Wheel>();
    }

    public void SetSpeed(int angle)
    {
        angle -= 90;
        wheel.Turn(angle);
    }
}
