using UnityEngine;

public class PlayerIdle : PlayerGrounded
{
    public PlayerIdle(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName) : base(player, stateMachine, playerData, animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();

        Debug.Log("Idle");
        core.Movement.SetVelocityX(0f);
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        if (!isExitingState)
        {
            if (xInput != 0)
            {
                stateMachine.SwitchState(player.playerMovingState);
            }
        }

    }
}
