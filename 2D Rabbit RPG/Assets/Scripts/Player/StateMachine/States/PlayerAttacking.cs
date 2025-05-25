using UnityEngine;
using UnityEngine.InputSystem.XInput;

public class PlayerAttacking : PlayerAbility
{
    private Weapon weap;
    private int xInput;
    private float velocity;

    private bool shouldFlip;
    private bool setVelocity;

    public PlayerAttacking(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName) : base(player, stateMachine, playerData, animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();

        setVelocity = false;
        shouldFlip = true;
        // Enable weap sprite
        weap.EnterWeap();
    }

    public override void Exit()
    {
        base.Exit();

        // Disable weap sprite
        weap.ExitWeap();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        xInput = player.inputHandler.NormInputX;

        if (shouldFlip) {
            core.Movement.CheckIfShouldFlip(xInput);
        }

        if (setVelocity)
        {
            core.Movement.SetVelocityX(velocity * core.Movement.facingDir);
        }
    }

    public void SetWeap(Weapon weap)
    {
        this.weap = weap;
    }

    public void SetVelocity()
    {
        core.Movement.SetVelocityX(weap.velocity * core.Movement.facingDir);
        velocity = weap.velocity;

        setVelocity = true;
    }
    public void DisableFlip()
    {
        shouldFlip = false;
    }

    public override void AnimationTrigger()
    {
        base.AnimationTrigger();

        SetVelocity();
        DisableFlip();
    }

    public override void AnimationFinishTrigger()
    {
        base.AnimationFinishTrigger();

        isAbilityDone = true;
    }
}
