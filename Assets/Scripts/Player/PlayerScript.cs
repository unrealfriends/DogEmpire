using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerScript : MonoBehaviour
{

    public NavMeshAgent mNavMeshAgent;
    public Camera playerCamera;
    public Animator playerAnimator;

    private Inventory inventory;

    // bools
    public bool isWalking;

    // Start is called before the first frame update
    void Start()
    {
        inventory = new Inventory();
    }


    // Update is called once per frame
    private void Update()
    {
        // wenn linke maustaste gedr�ct wird
        if (Input.GetMouseButton(0))
        {
            MoveToMousePosition();
        }
    }

    // zu linken mausklick gehen
    void MoveToMousePosition()
    {
        Ray ray = playerCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100))
        {
            mNavMeshAgent.destination = hit.point;
        }
        // wenn ziel erreicht ist
        if (mNavMeshAgent.remainingDistance <= mNavMeshAgent.stoppingDistance)
        {
            // stoppen
            isWalking = false;
        }
        else
        {
            // sonst weitergehen
            isWalking = true;
        }
        // bool im animator entsprechend setzen
        playerAnimator.SetBool("isWalking", isWalking);

    }
}
