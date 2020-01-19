using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private int destPoint = 0;
    private UnityEngine.AI.NavMeshAgent agent;

    System.Random rand = new System.Random();

    void Awake()
    {

    }

    //Vector3[] points;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.autoBraking = false;
        GotoNextPoint();
    }


    void GotoNextPoint()
    {
        // Returns if no points have been set up
        if (Manager.instance.points.Length == 0)
        {
            print("It's empty!");
            return;
        }

        agent.SetDestination(Manager.instance.GetRandomPoint());
    }


    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 2.5f)
            GotoNextPoint();
    }
}
