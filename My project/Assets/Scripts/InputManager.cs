using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public PlayerMovementTopDown pmtd;
    public void OnPoulet()
    {
        print("Cot cot cot");
    }
    public void OnMove(InputValue value)
    {
        var dir = value.Get<Vector2>();
        pmtd.Move(dir);
    }
}
