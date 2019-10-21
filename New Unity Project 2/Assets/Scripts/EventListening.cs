﻿using UnityEngine;
using UnityEngine.Events;

public class EventListening : MonoBehaviour, IListen
{
    [HideInInspector]
    public UnityEvent Event {get; set;}
    public Object IRunObj;
    public IRun NewIRunObj { get; set;}

    public void Start()
    {
        NewIRunObj = IRunObj as IRun;
        Event.AddListener(NewIRunObj.Run);
    }

    private void OnMouseDown()
    {
        Event.Invoke();
        Event.RemoveListener(NewIRunObj.Run);
    }
}
