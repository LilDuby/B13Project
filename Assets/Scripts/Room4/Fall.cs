using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    public OpenDoor openDoor;

    public int openNum = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bottom Floor")
        {
            transform.position = new Vector3(13f, 0.15f, -47f);
        }
        else if (collision.gameObject.tag == "OpenFloor")
        {
            openNum = 5;
            openDoor.OpenDoorSituation();
        }
    }
}
