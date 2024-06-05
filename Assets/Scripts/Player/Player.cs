using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerController controller;

    public ItemData itemData;   
    public Action Interaction;

    public Interaction interaction;

    public Transform dropPosition;
    private void Awake()
    {
        PlayerManager.Instance.Player = this;
        controller = GetComponent<PlayerController>();
        interaction = GetComponent<Interaction>();
    }
}
