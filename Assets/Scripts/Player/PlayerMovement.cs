using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    //private Animator mAnimator;
    public NavMeshAgent mNavMeshAgent;

    public Camera playerCamera;

    public Animator playerAnimator;
    public bool isWalking;
    // Start is called before the first frame update
    void Start()
    {
        //mAnimator = GetComponent<Animator>();
        //mNavMeshAgent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    private void Update()
    {
            Ray ray = playerCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(ray, out hit, 100))
            {
                mNavMeshAgent.destination = hit.point;
            }
        }

        // wenn ziel erreicht ist
        if (mNavMeshAgent.remainingDistance <= mNavMeshAgent.stoppingDistance)
        {
            // stoppen
            isWalking = false;
        }
        else
        {
            // sonst weitegehen
            isWalking = true;
        }
        // bool im animator entsprechend setzen
        playerAnimator.SetBool("isWalking", isWalking);
    }
}
