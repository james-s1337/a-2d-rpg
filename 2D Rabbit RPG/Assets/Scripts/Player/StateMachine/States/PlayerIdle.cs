using UnityEngine;

public class PlayerIdle : PlayerGrounded
{
    public PlayerIdle(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName) : base(player, stateMachine, playerData, animBoolName)
    {
    }
}
