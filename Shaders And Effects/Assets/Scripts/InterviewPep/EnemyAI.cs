using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    public NavMeshAgent navAgent;    // Start is called before the first frame update
    public Vector3 offset = new Vector3(1f,0f,1f);
    void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            navAgent.SetDestination(player.position + offset);
        }
    }
}
