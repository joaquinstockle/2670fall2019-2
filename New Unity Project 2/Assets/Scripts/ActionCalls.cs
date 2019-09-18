using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;
using Vector3 = UnityEngine.Vector3;

public class ActionCalls : MonoBehaviour
{
    public float speed = 1f, rotateSpeed = 10f, scaleSpeed = .2f;
    private Vector3 location, rotations, scales;
    private UnityAction transformAction;
    private void Start()
    {
        transformAction = OnMove;
    }
    private void OnMouseDown()
    {
        if (transformAction == OnMove)
        {
            transformAction = OnRotate;
        }
        else if (transformAction == OnRotate)
        {
            transformAction = OnScale;
        }
        else if (transformAction == OnScale)
        {
            transformAction = OnMove;
        }
    }
    void Update()
    {
        transformAction();
    }
    public void OnMove()
    {
        location.x = speed * Time.deltaTime;
        transform.Translate(location);
    }
    public void OnRotate()
    {
        rotations.y = rotateSpeed * Time.deltaTime;
        transform.Rotate(rotations);
    }
    public void OnScale()
    {
        scales.Set( newX:scaleSpeed, newY: scaleSpeed, newZ: scaleSpeed);
        transform.localScale += scales;
    }
}
