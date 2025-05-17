using UnityEngine;

public class PlayerMoving : PlayerGrounded
{
    public PlayerMoving(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName) : base(player, stateMachine, playerData, animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();

        Debug.Log("Moving");
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        core.Movement.CheckIfShouldFlip(xInput);

        core.Movement.SetVelocityX(playerData.movementSpeed * xInput);

        if (!isExitingState)
        {
            if (xInput == 0)
            {
                stateMachine.SwitchState(player.playerIdleState);
            }
        }
    }
}
