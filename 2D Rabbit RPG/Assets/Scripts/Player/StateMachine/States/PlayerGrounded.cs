using UnityEngine;
using UnityEngine.Windows;

public class PlayerGrounded : PlayerState
{
    protected int xInput;
    protected int yInput;
    protected bool jumpInput;

    private bool isGrounded;
    public PlayerGrounded(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName) : base(player, stateMachine, playerData, animBoolName)
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

        // player.playerJumpingState.ResetJumps();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        xInput = player.inputHandler.NormInputX;
        yInput = player.inputHandler.NormInputY;
        jumpInput = player.inputHandler.jumpInput;

        /*
        if (player.inputHandler.AttackInputs[(int)CombatInputs.primary] && !isTouchingCeiling)
        {
            stateMachine.ChangeState(player.PrimaryAttackState);
        }
        else if (player.InputHandler.AttackInputs[(int)CombatInputs.secondary] && !isTouchingCeiling)
        {
            stateMachine.ChangeState(player.SecondaryAttackState);
        }
        else if (JumpInput && player.JumpState.CanJump())
        {
            stateMachine.ChangeState(player.JumpState);
        }
        else if (!isGrounded)
        {
            player.InAirState.StartCoyoteTime();
            stateMachine.ChangeState(player.InAirState);
        }
        else if (isTouchingWall && grabInput && isTouchingLedge)
        {
            stateMachine.ChangeState(player.WallGrabState);
        }
        else if (dashInput && player.DashState.CheckIfCanDash() && !isTouchingCeiling)
        {
            stateMachine.ChangeState(player.DashState);
        }

        */
    }

}
