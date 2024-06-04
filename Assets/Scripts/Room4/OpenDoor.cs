using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject Door;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "OpenFloor")
        {
            Door.transform.rotation = Quaternion.Euler(new Vector3(0f, 80f, 0f));
        }
    }
}
