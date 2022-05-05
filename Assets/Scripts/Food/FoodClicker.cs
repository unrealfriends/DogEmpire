using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodClicker : MonoBehaviour
{
    public float velocity = 5f;
    Vector3 mouseClickedPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Ray von mauszeiger auf object casten
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                mouseClickedPosition = hit.collider.transform.position;
                if (hit.transform != null)
                {
                    Rigidbody rb;
                    if (rb = hit.transform.GetComponent<Rigidbody>())
                    {
                        PrintName(hit.transform.gameObject);
                        MoveToPosition(rb);
                    }
                }
            }
        }

    }

    private void PrintName(GameObject go)
    {
        print(go.name);
    }

    private void MoveToPosition(Rigidbody rig)
    {
        Vector3 direction = (mouseClickedPosition - transform.position).normalized;
        rig.velocity = direction * velocity;
    }
}
