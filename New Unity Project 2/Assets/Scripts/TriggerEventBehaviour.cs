using System;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBehaviour : MonoBehaviour
{
    public UnityEvent TriggerEnterEvent, TriggerStayEvent;

    public void OnTriggerEnter(Collider other)
    {
        TriggerEnterEvent.Invoke();
    }
    

    private void OnTriggerStay(Collider other)
    {
        TriggerStayEvent.Invoke();
    }
}
