using UnityEngine;

public class KeypadUI : MonoBehaviour
{   
    public GameObject keyPad;
    public GameObject keyPadUI;

    void Start()
    {
        PlayerManager.Instance.Player.Interaction += OnKeyPadUI;
    }
    public void OnKeyPadUI()
    {   
        keyPad= PlayerManager.Instance.Player.interaction.curInteractGameObject;
        PlayerManager.Instance.Player.controller.ToggleCursor();
        keyPadUI.SetActive(true);
    }
}
