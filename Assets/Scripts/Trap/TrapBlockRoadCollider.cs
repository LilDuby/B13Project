using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapBlockRoadCollider : MonoBehaviour
{
    public int blockSpeed;
    public bool right;

    private void OnTriggerEnter(Collider other)
    {

        if(other.TryGetComponent(out Rigidbody _rigidbody))
        {
            if (right)
            {
                _rigidbody.AddForce(Vector3.right * blockSpeed, ForceMode.Impulse);
            }
            else
            {
                _rigidbody.AddForce(Vector3.left * blockSpeed, ForceMode.Impulse);
            }
        }
    }
}
