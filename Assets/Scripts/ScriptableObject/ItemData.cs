using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ItemType
{
    CanPickUp,
    Resource,

    Interaction
}

[CreateAssetMenu(fileName = "Item", menuName = "New Item")]
public class ItemData : ScriptableObject
{
    [Header("Info")]
    public string displayName;
    public string description;
    public ItemType type;
    public GameObject dropPrefab;
    public bool isKey;

    [Header("PickUp")]
    public GameObject PickUpPrefeb;

    [Header("UI")]
    public GameObject KeyPadUI;
}
