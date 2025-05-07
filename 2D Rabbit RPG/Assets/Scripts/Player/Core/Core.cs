using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Core : MonoBehaviour
{
    public Movement Movement
    {
        get => movement;
        private set => movement = value;
    }
    public CollisionSense CollisionSenses
    {
        get => colSense;
        private set => colSense = value;
    }

    private Movement movement;
    private CollisionSense colSense;

    private void Awake()
    {
        movement = GetComponentInChildren<Movement>();
        colSense = GetComponentInChildren<CollisionSense>();
    }

    private void LogicUpdate()
    {
        // movement.LogicUpdate();
        // colSense.LogicUpdate(); 
    }
}
