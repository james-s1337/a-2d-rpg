using Unity.VisualScripting;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private GameObject startPoint, finishPoint;

    private GameObject currentObjective;
    private void Start()
    {
        currentObjective = startPoint;
    }

    private void Update()
    {
        if (!currentObjective)
        {
            Debug.Log("No objective set!");
            return;
        }

        float distFromObjective = gameObject.transform.position.x - currentObjective.transform.position.x;
       

        if (distFromObjective <= 0.01f && currentObjective.name == "Start")
        {
            currentObjective = finishPoint;
        }
        else if (distFromObjective >= -0.01f && currentObjective.name == "Finish")
        {
            currentObjective = startPoint;
        }

        int dir = -1; // Direction the platform will travel towards
        if (distFromObjective < 0)
        {
            dir = 1;
        }
        transform.Translate(new Vector3(speed * Time.deltaTime * dir, 0, 0), Space.World);
    }
}
