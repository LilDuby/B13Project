using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpRoomButton : MonoBehaviour
{
    public JumpRoomButtonData buttonData;
    public JumpRoomDoorController doorController;

    private void OnCollisionEnter(Collision collision)
    {
        if (buttonData.buttonType == ButtonType.Right)
        {
            Debug.Log("Right");
            doorController.OpenDoor();
        }
        else
        {
            Debug.Log("Wrong");
            return;
        }
    }
}
