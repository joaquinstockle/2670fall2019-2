using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class Collections : ScriptableObject
{
    public List<Object> objectList;

    public void FindObjectType(Object obj)
    {
        foreach (var currentOnj in objectList)
        {
            if (currentOnj == obj)
            {
                //stuff;
            }
        }
    }

    public void AddToList(Object obj)
    {
        objectList.Add(obj);
    }

    public void RemoveFromList(Object obj)
    {
        foreach (var currentOnj in objectList)
        {
            if (currentOnj == obj)
            {
                objectList.Remove(obj);
            }
        }
    }

}
