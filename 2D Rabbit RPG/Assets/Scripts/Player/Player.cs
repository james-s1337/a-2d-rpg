using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region Player States
    PlayerIdle playerIdleState;
    PlayerMoving playerMovingState;
    PlayerJumping playerJumpingState;
    PlayerLanded playerLandedState;
    PlayerInAir playerInAirState;

    PlayerStateMachine stateMachine;
    #endregion

    PlayerInputHandler inputHandler;
    Core core;
    [SerializeField] PlayerData playerData;
    public Animator anim { get; private set; }
    public Rigidbody2D rb { get; private set; }

    private void Awake()
    {
        core = GetComponentInChildren<Core>();

        stateMachine = new PlayerStateMachine();

        playerIdleState = new PlayerIdle(this, stateMachine, playerData, "idle");
        playerMovingState = new PlayerMoving(this, stateMachine, playerData, "move");
        playerJumpingState = new PlayerJumping(this, stateMachine, playerData, "inAir");
        playerLandedState = new PlayerLanded(this, stateMachine, playerData, "land");
        playerInAirState = new PlayerInAir(this, stateMachine, playerData, "inAir");       
    }

    private void Start()
    {
        anim = GetComponent<Animator>();
        inputHandler = GetComponent<PlayerInputHandler>();
        rb = GetComponent<Rigidbody2D>();
        //DashDirectionIndicator = transform.Find("DashDirectionIndicator");
        //MovementCollider = GetComponent<BoxCollider2D>();
        //Inventory = GetComponent<PlayerInventory>();

        //PrimaryAttackState.SetWeapon(Inventory.weapons[(int)CombatInputs.primary]);
        //SecondaryAttackState.SetWeapon(Inventory.weapons[(int)CombatInputs.primary]);
        stateMachine.Initiate(playerIdleState);
    }

    private void Update()
    {
        core.LogicUpdate();
        stateMachine.currentState.LogicUpdate();
    }

    private void AnimationTrigger() => stateMachine.currentState.AnimationTrigger();

    private void AnimtionFinishTrigger() => stateMachine.currentState.AnimationFinishTrigger();
}
