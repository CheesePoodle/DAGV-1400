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
            Debug.Log("Matched ID: " + id);
        } else
        {
            noMatchEvent.Invoke();
            Debug.Log("No match: " + id);
        }
    }
}
