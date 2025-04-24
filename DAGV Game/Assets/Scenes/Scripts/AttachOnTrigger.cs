using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachOnTrigger : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Event Triggered");
         transform.parent = other.transform;
    }

    public void OnTriggerExit(Collider other)
    {
        transform.parent = null;
    }
}
