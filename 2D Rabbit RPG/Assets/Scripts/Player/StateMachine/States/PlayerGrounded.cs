using UnityEngine;

public class PlayerGrounded : PlayerState
{
    public PlayerGrounded(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName) : base(player, stateMachine, playerData, animBoolName)
    {
    }
}
