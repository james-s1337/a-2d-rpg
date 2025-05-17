using UnityEngine;

public class PlayerMoving : PlayerGrounded
{
    public PlayerMoving(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName) : base(player, stateMachine, playerData, animBoolName)
    {
    }
}
