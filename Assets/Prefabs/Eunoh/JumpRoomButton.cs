using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpRoomButton : MonoBehaviour
{
    public JumpRoomButtonData buttonData;
    public GameObject keyNumber;

    private void OnCollisionEnter(Collision collision)
    {
        if (buttonData.buttonType == ButtonType.Right)
        {
            keyNumber.SetActive(true);
        }
        else
        {
            return;
        }
    }
}
