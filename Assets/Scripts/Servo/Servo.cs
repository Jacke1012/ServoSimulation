using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FoldergeistAssets.Singleton;

public class Servo : SceneSingletonMB<Servo>
{
    public override void OnInstantiated() { }


    [SerializeField]
    private MotorModule[] leftServoChoose;
    [SerializeField]
    private MotorModule[] rightServoChoose;
    
    public MotorPair leftServos;
    public MotorPair rightServos;

    public int rightAngle = 90;
    public int leftAngle = 90;


    private void Awake()
    {
        leftServos = new MotorPair(leftServoChoose);
        rightServos = new MotorPair(rightServoChoose);
    }

    public float forceMultiplyer = 1.0f;

    private void Update()
    {
        leftServos.Turn(leftAngle);
        leftServos.Turn(rightAngle);
    }

}
