using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageController : MonoBehaviour
{
    public Image imageComponent;

   
    private void Start()
    {
        imageComponent = GetComponent<Image>();
    }
    
    //public void UpdateImageComponent()

    public void UpdateImageComponent(FloatData dataObj)
    {
        imageComponent.fillAmount = dataObj.value;
    }

}
