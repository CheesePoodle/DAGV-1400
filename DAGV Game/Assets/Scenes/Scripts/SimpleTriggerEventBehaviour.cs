using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimpleTriggerEventBehaviour : MonoBehaviour
{
    public UnityEvent triggerEvent;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Player touched the guy!");
            triggerEvent.Invoke();
            if (other.gameObject.tag == "Collectible")
            {
                Destroy(other.gameObject);
            }
            else if (other.gameObject.tag == "HealthObject")
            {
                Destroy(other.gameObject);
            }
        }
        //trigger the event and test with a debug message
        
    }

}
