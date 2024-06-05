using UnityEngine;

public class KeypadUI : MonoBehaviour
{
    public GameObject keyPadUI;

    void Start()
    {
        PlayerManager.Instance.Player.Interaction += OnKeyPadUI;
    }
    public void OnKeyPadUI()
    {          
        keyPadUI.SetActive(true);
        PlayerManager.Instance.Player.controller.ToggleCursor();
    }
}
