using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class JumpRoomDoorController : MonoBehaviour
{
    public float openAngle = 90f;
    public float closeAngle = 0f;
    public float rotationSpeed = 2f;
    public GameObject keyNumber;
    
    private bool needRotate = false;
    private bool isOpening = true;

    private Quaternion idleRotation;
    private Quaternion openRotation;
    private Quaternion closeRotation;
    private Quaternion targetRotation;

    public JumpPad pad;

    void Start()
    {
        idleRotation = transform.rotation;
        openRotation = Quaternion.Euler(0, openAngle, 0) * idleRotation;
        closeRotation = Quaternion.Euler(0, closeAngle, 0) * idleRotation;
        if(keyNumber != null)
        {
            keyNumber.SetActive(false);
        }
    }

    void Update()
    {


        if (needRotate)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, closeRotation, Time.deltaTime * rotationSpeed);

            if (Quaternion.Angle(transform.rotation, closeRotation) < 0.1f)
            {
                transform.rotation = closeRotation;
                needRotate = false;
                keyNumber.SetActive(true);
            }
        }


    }

    public void OpenDoor()
    {
        targetRotation = openRotation;
        needRotate = true;
        isOpening = true;
    }

    public void CloseDoor()
    {
        targetRotation = closeRotation;
        needRotate = true;
        isOpening = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("JumpPad"))
        {
            CloseDoor();
        }
    }
}
