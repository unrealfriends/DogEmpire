using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    //private Animator mAnimator;
    public NavMeshAgent mNavMeshAgent;

    private bool mRunning = false;
    public Camera playerCamera;
    // Start is called before the first frame update
    void Start()
    {
        //mAnimator = GetComponent<Animator>();
        mNavMeshAgent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    private void Update()
    {
            Ray ray = playerCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
        if (Input.GetMouseButton(0))
        {
            print ("HELLO");
            if (Physics.Raycast(ray, out hit, 100))
            {
                mNavMeshAgent.destination = hit.point;
            }
        }

        //if (mNavMeshAgent.remainingDistance <= mNavMeshAgent.stoppingDistance)
        //{
        //    mRunning = false;
        //}
        //else
        //{
        //    mRunning = true;
        //}

        //mAnimator.SetBool("running", mRunning);
    }
}
