using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapGhost : MonoBehaviour
{
    public GameObject Ghost;
    Transform transform;

    private void Start()
    {
        transform = Ghost.transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Player>() != null)
        {
            Ghost.SetActive(true);
        }
    }

    void MoveGhost()
    {
        transform.position += new Vector3(0, 0, 0.1f);
    }
}
