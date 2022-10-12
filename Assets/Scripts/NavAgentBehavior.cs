using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class NavAgentBehavior : MonoBehaviour
{
    private NavMeshAgent agent;
    public Vector3Data ObstacleTarg;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = ObstacleTarg.value;
    }
}
