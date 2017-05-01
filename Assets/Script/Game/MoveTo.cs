using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// Taken from Kyle's Example
public class MoveTo : MonoBehaviour
{

    public Transform goal;

    void Start()
    {
        var agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(goal.position);
    }

    public void ChangeGoal(Transform pos)
    {
        var agent = GetComponent<NavMeshAgent>();
        Vector3 temp = new Vector3(pos.position.x, pos.position.y, pos.position.z + 4);
        agent.SetDestination(temp);
    }
}
