using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneUI : MonoBehaviour
{
    public GameObject title;
    public GameObject menuButton;
    public GameObject manualPanel;


    public void ClickStartButton()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void ClickManualButton()
    {
        menuButton.SetActive(false);
        title.SetActive(false);
        manualPanel.SetActive(true);
    }

    public void ClickManualCloseButton()
    {
        menuButton.SetActive(true);
        title.SetActive(true);
        manualPanel.SetActive(false);
    }
}
