using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    InteractEvent interact = new InteractEvent();
    Player player;

    public InteractEvent GetInteractEvent
    {
        get
        {
            if (interact == null) interact = new InteractEvent();
            return interact;
        }
    }

    public Player GetPlayer
    {
        get
        {
            return player;
        }
    }

    public void CallInteract(Player interactedPlayer)
    {
        player = interactedPlayer;
        interact.CallInteractEvent();
    }
}

public class InteractEvent
{
    public delegate void InteractHandler();

    public event InteractHandler HasInteracted;

    public void CallInteractEvent() => HasInteracted?.Invoke();
}
