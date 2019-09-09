using UnityEngine;
using UnityEngine.Events;

public class GameObjectHandler : MonoBehaviour
{
    public GameAction gameActionObj;
    public UnityEvent handlerEvent;
    void Start()
    {
        gameActionObj.action += Action;
    }

    private void Action()
    {
        handlerEvent.Invoke();
    }
}
