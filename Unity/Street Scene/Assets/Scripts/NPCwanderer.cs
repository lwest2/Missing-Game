using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// reference: https://forum.unity.com/threads/solved-random-wander-ai-using-navmesh.327950/

public class NPCwanderer : MonoBehaviour {

    [SerializeField]
    private float m_wanderRadius;     // wander radius   
    [SerializeField]
    private float m_wanderTimer;       // wander time

    private Transform m_transform;
    private NavMeshAgent m_agent;
    private float m_timer;

    private void OnEnable()
    {
        m_transform = GetComponent<Transform>();
        m_agent = GetComponent<NavMeshAgent>();
        m_timer = m_wanderTimer;         
    }

    private void Update()
    {
        // add time from real update time
        m_timer += Time.deltaTime;
        // if timer is more or equal to original time
        if(m_timer >= m_wanderTimer)
        {
            // call new position
            Vector3 newPos = RandomNavSphere(m_transform.position, m_wanderRadius, -1);
            // set position
            m_agent.SetDestination(newPos);
            // reset timer to 0
            m_timer = 0;
        }
    }

    public Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask)
    {
        // random direction within a sphere radius
        Vector3 randDirection = Random.insideUnitSphere * dist;

        // add origin
        randDirection += origin;

        // calculate navmesh destination
        NavMeshHit navHit;
        
        NavMesh.SamplePosition(randDirection, out navHit, dist, layermask);

        return navHit.position;
    }
}
