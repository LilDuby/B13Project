using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapBlockRoad : MonoBehaviour
{
    public GameObject leftCollider;
    public GameObject rightCollider;
    BoxCollider boxCollider;

    AudioSource audioSource;
    public AudioClip blockClip;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        boxCollider = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Player>() != null)
        {
            leftCollider.gameObject.SetActive(true);
            rightCollider.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(boxCollider);
    }

    void PlayBlockClip()
    {
        audioSource.PlayOneShot(blockClip);
    }
}
