using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Script2Dest : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform[] _dest = new Transform[2];
    int _index;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Start()
    {
        agent.autoBraking = true;
        agent.SetDestination(_dest[0].position);
        _index = 1;
    }

    void Update()
    {
        if (agent.remainingDistance == 0)
        {
            switch (_index)
            {
                case 1:
                    agent.SetDestination(_dest[1].position);
                    _index++;
                    break;
                case 2:
                    agent.SetDestination(_dest[0].position);
                    _index = 1;
                    break;
            }
        }
    }
}
