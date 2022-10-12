using UnityEngine;
using UnityEngine.Events;

public class CollBehavior : MonoBehaviour
{
    public UnityEvent collisionEvent;

    private void OnTriggerEnter(Collider other)
    {
        collisionEvent.Invoke();
    }
}
