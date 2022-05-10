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

    [SerializeField] private UI_Inventory uiInventory;

    // Start is called before the first frame update
    void Start()
    {
        inventory = new Inventory();
        uiInventory.SetInventory(inventory);

        //ItemWorld.SpawnItemWorld(new Vector3(20, 20), new Item { itemType = Item.ItemType.Wood, amount = 1 });
        //ItemWorld.SpawnItemWorld(new Vector3(-20, -20), new Item { itemType = Item.ItemType.Wood, amount = 1 });
        //ItemWorld.SpawnItemWorld(new Vector3(0, 20), new Item { itemType = Item.ItemType.WoodCrate, amount = 1 });
    }


    // Update is called once per frame
    private void Update()
    {
        // wenn linke maustaste gedrüct wird
        if (Input.GetMouseButton(0))
        {
            MoveToMousePosition();
        }
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
    }
}
