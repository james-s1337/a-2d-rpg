using UnityEngine;

public class PlayerInAir : PlayerState
{
    public PlayerInAir(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName) : base(player, stateMachine, playerData, animBoolName)
    {
    }
}
