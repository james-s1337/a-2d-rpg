using UnityEngine;

public class PlayerState : MonoBehaviour
{
    protected Core core; // Methods for movement and collision detection

    protected Player player;
    protected PlayerStateMachine stateMachine;
    protected PlayerData playerData;

    protected bool isAnimationFinished;
    protected bool isExitingState;

    protected float startTime;

    private string animBoolName;

    public PlayerState(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName)
    {
        this.player = player;
        this.stateMachine = stateMachine;
        this.playerData = playerData;
        this.animBoolName = animBoolName;
        core = player.core;
    }

    public virtual void Enter()
    {
        DoChecks();
        // player.Anim.SetBool(animBoolName, true);
        startTime = Time.time;
        //Debug.Log(animBoolName);
        isAnimationFinished = false;
        isExitingState = false;
    }

    public virtual void Exit()
    {
        // player.Anim.SetBool(animBoolName, false);
        isExitingState = true;
    }

    public virtual void LogicUpdate() { } // Updates every Update()

    public virtual void DoChecks() { } // Ground check, ledge check etc.

    public virtual void AnimationTrigger() { } // Triggered in anim

    public virtual void AnimationFinishTrigger() => isAnimationFinished = true; // Triggered in anim
}
