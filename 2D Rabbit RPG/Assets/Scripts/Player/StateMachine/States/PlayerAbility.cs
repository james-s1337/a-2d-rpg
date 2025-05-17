using UnityEngine;

public class PlayerAbility : PlayerState
{
    public PlayerAbility(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName) : base(player, stateMachine, playerData, animBoolName)
    {
    }
}
