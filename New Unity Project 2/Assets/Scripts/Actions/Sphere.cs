using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public GameAction GameActionObj;

    public void Talk()
    {
        Debug.Log("Sphere");
    }

    private void Awake()
    {
        GameActionObj.action += Talk;
    }

    void Start()
    {
        
    }
}
