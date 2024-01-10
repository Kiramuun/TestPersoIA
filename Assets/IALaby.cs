using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IALaby : MonoBehaviour
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
        agent.SetDestination(_dest[0].position);
        _index = 1;
    }

    void Update()
    {
        if (agent.remainingDistance == 0)
        {
            if (_index == 1)
            {
                agent.SetDestination(_dest[1].position);
                _index = 0;
            }
            else
            {
                agent.SetDestination(_dest[0].position);
                _index = 1;
            }
        }
        if (agent.hasPath)
        {
            Debug.Log("chemin trouvé");
        }
    }
}
