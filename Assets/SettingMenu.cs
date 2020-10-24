using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SettingMenu : MonoBehaviour
{
    public Vector3 movePos = new Vector3(400,0,0);

    private RectTransform rectTransform;


    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void Open() => LeanTween.move(rectTransform, Vector3.zero, 0.3f);
    public void Close() => LeanTween.move(rectTransform, movePos, 0.3f);


    public void ChangeLeftServo(string text) => Servo.Instance.leftAngle = int.Parse(text);
    public void ChangeRightServo(string text) => Servo.Instance.rightAngle = int.Parse(text);
    public void ChangeForceMultiplyer(string text) => Servo.Instance.forceMultiplyer = int.Parse(text);
}
