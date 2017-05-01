using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GoBetween : MonoBehaviour {
    public Transform goal;
    public GameObject player;
    public GameObject agentBoss;
    private Transform temp;

    void Start()
    {
        var agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(goal.position);
        InvokeRepeating("GetNextPos", 2, .2f);
    }

    public void ChangeGoal(Transform pos)
    {
        var agent = GetComponent<NavMeshAgent>();
        Vector3 temp = new Vector3(pos.position.x, pos.position.y, pos.position.z);
        agent.SetDestination(temp);
    }

    void Update()
    {
        agentBoss.transform.LookAt(player.transform);
    }

    void GetNextPos()
    {
        temp = player.transform;
        ChangeGoal(temp);
    }
}
