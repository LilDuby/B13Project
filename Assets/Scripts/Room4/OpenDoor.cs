using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Fall fall;

    //public GameObject Door;

    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (fall.openNum == 5)
        {
            animator.SetInteger("Open", 5);
        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == "OpenFloor")
    //    {
    //        //Door.transform.rotation = Quaternion.Euler(new Vector3(0f, 80f, 0f));
    //        animator.SetInteger("Open", 5);
    //    }
    //}
}
