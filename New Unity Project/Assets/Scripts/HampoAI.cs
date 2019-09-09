using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HampoAI : MonoBehaviour
{
    public List<Transform> target;
    private NavMeshAgent agent;
    private int currentDestination;
    public float targetDistanceThreshold;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (agent.remainingDistance < targetDistanceThreshold)
        {
            SetNewDestination();
        }

    }

    private void SetNewDestination()
    {
        currentDestination++;

        if (currentDestination > target.Count - 1)
        {
            currentDestination = 0;
        }
            agent.SetDestination(target[currentDestination].position);
        }

    
}