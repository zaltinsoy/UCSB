using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CatMoves : MonoBehaviour
{
    public float speed = 3.0f;
    public GameObject target1;
    public GameObject target2;
    public GameObject target3;
    public GameObject targetReal;
    public NavMeshAgent agent;
    public int randomInt; 

    void Start()
    {
        //Randomly decide which target to go
        randomInt = Random.Range(0, 3);
        targetReal = ChooseAgent(randomInt);
        Debug.Log(randomInt);
    }

    void Update()
    {

        targetReal = ChooseAgent(randomInt);
        agent.SetDestination(targetReal.transform.position);
    }
    //randomize target choice
    private GameObject ChooseAgent(int choice)
    {
        switch (choice)
        {
           
            case 0:
                return targetReal = target1;
                break;
            case 1:
                return targetReal = target2;
                break;
            case 2:
                return targetReal = target3;
                break;
        }
        return targetReal;

    }


}

