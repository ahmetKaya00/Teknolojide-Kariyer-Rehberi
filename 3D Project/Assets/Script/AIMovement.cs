using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMovement : MonoBehaviour
{
    NavMeshAgent agent;

    public Transform target;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        float mesafe = Vector3.Distance(transform.position, target.position);

        if (mesafe < 8f)
        {
            agent.destination = target.position;
        }
    }
}
