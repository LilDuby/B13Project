using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IInteractable
{
    public string GetInteractPrompt();
    public bool OnInteract();
}

public class ItemObject : MonoBehaviour, IInteractable
{

    public ItemData data;

    public string GetInteractPrompt()
    {
        string str = $"{data.displayName}\n{data.description}";
        return str;
    }

    public bool OnInteract()
    {
        if (data.type == ItemType.CanPickUp)
        {
            PlayerManager.Instance.Player.itemData = data;           
            Destroy(gameObject);
            PlayerManager.Instance.Player.controller.PickUpNew(data);
            return true;
        }
        else if (data.type == ItemType.Interaction)
        {
            PlayerManager.Instance.Player.itemData = data; 
            PlayerManager.Instance.Player.Interaction?.Invoke();
            return true;
        }
        return false;
    }
}
