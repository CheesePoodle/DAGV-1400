using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Color newColor = Color.red;

    private void OnCollisionEnter(Collision collision)
    {
        //change the objects color upon collision
        GetComponent<Renderer>().material.color = newColor;
    }
}
