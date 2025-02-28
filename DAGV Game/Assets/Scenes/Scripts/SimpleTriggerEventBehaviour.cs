using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimpleTriggerEventBehaviour : MonoBehaviour
{
    public UnityEvent triggerEvent;

    private void OnTriggerEnter(Collider other)
    {
        //trigger the event and test with a debug message
        Debug.Log("Player touched the guy!");
        triggerEvent.Invoke();
    }

}
