using UnityEngine;

// Used for entities that need to be freezed in the overworld when combat is initiated
// Ex. Player, Enemy, MoveableObject
public interface IFreezeable
{
    void Freeze(); 
}
