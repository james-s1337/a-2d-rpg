using UnityEngine;

[CreateAssetMenu(fileName = "newPlayerData", menuName = "Data/Player Data/Base Data")]
public class PlayerData : ScriptableObject
{
    [Header("Movement")]
    public float movementSpeed = 10.0f;
    public float jumpPower = 10.0f;
    public int jumps = 1;
    public float coyoteTime = 0.2f;
    public float jumpMult = 2f;

    [Header("Vitals")]
    public int health = 10;

}
