using UnityEngine;

public class PlayerJumping : PlayerState
{
    public PlayerJumping(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName) : base(player, stateMachine, playerData, animBoolName)
    {
    }
}
