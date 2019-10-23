using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

[CreateAssetMenu]
public class MoveHVArrows : ScriptableObject, IMove
{
    public Vector3 location { get; set; }
    public Vector3 newLoc;

    public void Move(CharacterController controller)
    {
        newLoc.x = Input.GetAxis("Horizontal")*Time.deltaTime;
        controller.Move(newLoc);
    }
}
