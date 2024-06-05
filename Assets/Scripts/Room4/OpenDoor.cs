using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public AudioClip openDoorSound;
    AudioSource audioSource;

    public Fall fall;

    public GameObject password4;

    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (fall.openNum == 5)
        {
            audioSource.PlayOneShot(openDoorSound);
            animator.SetInteger("Open", 5);
            password4.SetActive(true);
        }
    }
}
