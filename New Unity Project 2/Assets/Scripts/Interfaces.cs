using System.Numerics;
using UnityEngine;
using UnityEngine.Events;
using Vector3 = UnityEngine.Vector3;

public interface IRun
{
    void Run();
}

public interface ITest
{
    void Test();
}

public interface IListen
{
    UnityEvent Event { get; set; }
    IRun NewIRunObj { get; set; }
    void Start();
}

public interface ITrigger
{
    void onTriggerEnter(Collider obj);
}

public interface IMove
{
    Vector3 location { get; set; }
    void Move(CharacterController controller);
}