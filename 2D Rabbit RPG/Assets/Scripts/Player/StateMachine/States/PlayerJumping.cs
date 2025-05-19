using UnityEngine;

public class PlayerJumping : PlayerAbility
{
    private int amountOfJumpsLeft;

    public PlayerJumping(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName) : base(player, stateMachine, playerData, animBoolName)
    {
        amountOfJumpsLeft = playerData.jumps;
    }

    public override void Enter()
    {
        base.Enter();

        player.inputHandler.UseJumpInput();
        core.Movement.SetVelocityY(playerData.jumpPower);
        isAbilityDone = true;
        amountOfJumpsLeft--;
        player.playerInAirState.SetIsJumping();
        Debug.Log("Jumping");
    }

    public bool CanJump()
    {
        if (amountOfJumpsLeft > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void ResetAmountOfJumpsLeft() => amountOfJumpsLeft = playerData.jumps;

    public void DecreaseAmountOfJumpsLeft() => amountOfJumpsLeft--;
}
