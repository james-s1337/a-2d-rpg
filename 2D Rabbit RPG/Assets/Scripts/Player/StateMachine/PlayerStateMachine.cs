using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class PlayerStateMachine
{
    public PlayerState currentState { get; private set; }

    public void Initiate(PlayerState newState)
    {
        currentState = newState;
        currentState.Enter();
    }
    public void SwitchState(PlayerState newState)
    {
        
        currentState.Exit();
        currentState = newState;
        currentState.Enter();
    }
}
