using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Script4Dest : MonoBehaviour
{
    NavMeshAgent _agent;
    public Transform[] _dest = new Transform[4];
    int _index;

    void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    void Start()
    {
        _agent.autoBraking = true;
        _agent.SetDestination(_dest[0].position);
        _index = 1;
    }

    void Update()
    {
        if (_agent.remainingDistance == 0)
        {
            switch (_index)
            {
                case 1:
                    _agent.SetDestination(_dest[1].position);
                    _index++;
                    break;
                case 2:
                    _agent.SetDestination(_dest[2].position);
                    _index++;
                    break;
                case 3:
                    _agent.SetDestination(_dest[3].position);
                    _index++;
                    break;
                case 4:
                    _agent.SetDestination(_dest[0].position);
                    _index = 1;
                    break;
            }
        }
    }
}
