using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    //Item Variables

    //Chest Open Animations

    public Interact openFromInteraction;

    private void OnEnable()
    {
        if (openFromInteraction)
        {
            openFromInteraction.GetInteractEvent.HasInteracted += OpenChest;
        }
    }

    private void OnDisable()
    {
        if (openFromInteraction)
        {
            openFromInteraction.GetInteractEvent.HasInteracted -= OpenChest;
        }
    }

    public void OpenChest()
    {
        Debug.Log("Opened Chest");
    }
}
