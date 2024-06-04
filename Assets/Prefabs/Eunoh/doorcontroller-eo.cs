using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorcontroller : MonoBehaviour
{
    public float openAngle = 90f;
    public float rotationSpeed = 2f;
    private bool needRotate = false;

    private Quaternion idleRotation;
    private Quaternion openRotation;

    void Start()
    {
        idleRotation = transform.rotation;
        openRotation = Quaternion.Euler(0, openAngle, 0) * idleRotation;
    }


    void Update()
    {
        if (needRotate)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, openRotation, Time.deltaTime * rotationSpeed);
        }
    }
}
