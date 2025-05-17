using UnityEngine;

public class PlayerLanded : PlayerGrounded
{
    public PlayerLanded(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName) : base(player, stateMachine, playerData, animBoolName)
    {
    }
}
