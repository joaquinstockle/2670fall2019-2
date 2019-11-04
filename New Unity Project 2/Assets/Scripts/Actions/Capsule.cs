using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{

    public GameAction gameActionOj;
    public void Yell()
    {
        Debug.Log("Capsule");
    }
    
    private void Awake()
    {
        
    }

    private void Start()
    {
        gameActionOj.Raise();
    }
}
