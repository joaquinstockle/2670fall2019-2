﻿using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]

public class GameAction : ScriptableObject
{
    public UnityAction action;
    public UnityAction<Transform> transformAction;
    public void Raise()
    {
        action.Invoke();
    }
}