using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public string item;
    public int amount;

    public Interact pickupFromInteract;

    private void OnEnable()
    {
        Interact check = GetComponent<Interact>();
        if (check)
        {
            pickupFromInteract = check;
            pickupFromInteract.GetInteractEvent.HasInteracted += InteractPickup;
        }
        else
        {
            Interact addComp = this.gameObject.AddComponent<Interact>();
            pickupFromInteract = addComp;
            pickupFromInteract.GetInteractEvent.HasInteracted += InteractPickup;
        }
    }
    private void OnDisable()
    {
        if (pickupFromInteract)
        {
            pickupFromInteract.GetInteractEvent.HasInteracted -= InteractPickup;
        }
    }

    public void InteractPickup()
    {
        AddItem(pickupFromInteract.GetPlayer);
    }

    public void AddItem(Player player)
    {
        Debug.Log("Added " + item + " item to " + player);
    }
}
