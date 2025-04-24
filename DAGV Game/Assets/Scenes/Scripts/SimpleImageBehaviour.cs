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
        imageObj.fillAmount = 0.5f;
    }

    public void UpdateWithFloatData()
    {
        imageObj.fillAmount = dataObj.value;
    }
}
