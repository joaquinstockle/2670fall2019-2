using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[RequireComponent(typeof(Image))]
public class ImageController : MonoBehaviour
{
    public Image imageComponent;
    public UnityEvent UpdateImageEvent;
   
    private void Start()
    {
        imageComponent = GetComponent<Image>();
    }

    public void UpdateImageComponent(FloatData dataObj)
    {
        imageComponent.fillAmount = dataObj.value;
    }
    
    private void Update()
    {
        UpdateImageEvent.Invoke();
    }
}
