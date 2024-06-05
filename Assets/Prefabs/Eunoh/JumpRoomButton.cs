using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpRoomButton : MonoBehaviour
{
    public JumpRoomButtonData buttonData;
    public DoorControllerEO doorController;

    private void OnCollisionEnter(Collision collision)
    {
        if (buttonData.buttonType == ButtonType.Right)
        {
            doorController.OpenDoor();
        }
        else
        {
            return;
        }
    }
}
