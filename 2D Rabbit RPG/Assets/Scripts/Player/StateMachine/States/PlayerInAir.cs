using UnityEngine;

public class PlayerInAir : PlayerState
{
    private int xInput;
    private bool jumpInput;
    private bool jumpInputStop;

    private bool isGrounded;
    private bool coyoteTime;
    private bool isJumping;

    public PlayerInAir(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName) : base(player, stateMachine, playerData, animBoolName)
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

        Debug.Log("In Air");
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        CheckCoyoteTime();

        isGrounded = core.CollisionSenses.Ground;
        xInput = player.inputHandler.NormInputX;
        jumpInput = player.inputHandler.jumpInput;
        jumpInputStop = player.inputHandler.jumpInputStop;

        CheckJumpMultiplier();

        if (isGrounded && core.Movement.velocity.y < 0.01f)
        {
            stateMachine.SwitchState(player.playerLandedState);
        }
        else if (jumpInput && player.playerJumpingState.CanJump())
        {
            stateMachine.SwitchState(player.playerJumpingState);
        }
        else
        {
            core.Movement.CheckIfShouldFlip(xInput);
            core.Movement.SetVelocityX(playerData.movementSpeed * xInput);

            player.anim.SetFloat("yVelocity", core.Movement.velocity.y);
        }
    }

    private void CheckJumpMultiplier()
    {
        if (isJumping)
        {
            if (jumpInputStop)
            {
                core.Movement.SetVelocityY(core.Movement.velocity.y * playerData.jumpMult);
                isJumping = false;
            }
            else if (core.Movement.velocity.y <= 0f)
            {
                isJumping = false;
            }

        }
    }

    private void CheckCoyoteTime()
    {
        if (coyoteTime && Time.time > startTime + playerData.coyoteTime)
        {
            coyoteTime = false;
            player.playerJumpingState.DecreaseAmountOfJumpsLeft();
        }
    }
    public void StartCoyoteTime() => coyoteTime = true;
    public void SetIsJumping() => isJumping = true;
}
