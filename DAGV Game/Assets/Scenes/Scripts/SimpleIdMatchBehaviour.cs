using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimpleIdMatchBehaviour : MonoBehaviour
{
    public Id id;
    public UnityEvent matchEvent, noMatchEvent;

    private void OnTriggerEnter(Collider other)
    {
        var otherId = other.GetComponent<SimpleIdBehaviour>();

        if(otherId.id == id)
        {
            matchEvent.Invoke();
            Destroy(other.gameObject); //Fire turns off, key is destroyed, and the player can continue through the level.
        } 
        else
        {
            noMatchEvent.Invoke(); //Fire animation continues
        }
    }
}
