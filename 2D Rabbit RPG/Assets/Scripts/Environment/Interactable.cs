using Unity.VisualScripting;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    protected virtual void Activate() { }
    protected virtual void Deactivate() { }
    protected virtual void OnCollisionEnter2D() { }
}
