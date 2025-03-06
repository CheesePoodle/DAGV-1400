using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class SimpleImageBehaviour : MonoBehaviour
{
    private Image imageObj;
    public SimpleFloatData dataObj;

    private void Start()
    {
        imageObj = GetComponent<Image>();
    }

    private void Update()
    {
        imageObj.fillAmount = dataObj.value;
    }

}
