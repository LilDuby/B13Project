using UnityEngine;

public class KeypadUI : MonoBehaviour
{
    public GameObject keyPadUI;
    public void OnKeyPadUI()
    {          
        keyPadUI.SetActive(true);
        PlayerManager.Instance.Player.controller.ToggleCursor();
    }
}
