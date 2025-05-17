using UnityEngine;

public class PlayerLanded : PlayerGrounded
{
    public PlayerLanded(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName) : base(player, stateMachine, playerData, animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();

        Debug.Log("Landed on ground");
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
            else if (isAnimationFinished)
            {
                stateMachine.SwitchState(player.playerIdleState);
            }
        }
    }
}
