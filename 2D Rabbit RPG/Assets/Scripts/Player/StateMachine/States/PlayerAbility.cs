using UnityEngine;

public class PlayerAbility : PlayerState
{
    protected bool isAbilityDone;

    private bool isGrounded;
    public PlayerAbility(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName) : base(player, stateMachine, playerData, animBoolName)
    {
    }
    public override void DoChecks()
    {
        base.DoChecks();

        isGrounded = core.CollisionSenses.Ground;
    }

    public override void Enter()
    {
        base.Enter();

        isAbilityDone = false;
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        if (isAbilityDone)
        {
            if (isGrounded && core.Movement.velocity.y < 0.01f)
            {
                stateMachine.SwitchState(player.playerIdleState);
            }
            else
            {
                stateMachine.SwitchState(player.playerInAirState);
            }
        }
    }
}
