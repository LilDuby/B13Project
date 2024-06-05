using UnityEngine;

public class OpenDoor1 : MonoBehaviour
{
    public InputPad inputPad;
    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();        
    }

    private void Update()
    {
        if (inputPad.openNum == 4)
        {
            animator.SetInteger("Open", 4);            
        }
    }
}
