using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    private Vector2 movementInput;
    public int NormInputX { get; private set; }
    public int NormInputY { get; private set; }
    public bool jumpInput { get; private set; }

    public void OnMoveInput(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();

        NormInputX = Mathf.RoundToInt(movementInput.x);
        NormInputY = Mathf.RoundToInt(movementInput.y);
    }

    public void OnJumpInput(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            jumpInput = true;
        }

        if (context.canceled)
        {
        }
    }
}
