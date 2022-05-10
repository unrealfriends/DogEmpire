using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBehaviour : MonoBehaviour
{
    public int jumpVelocity = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // rotiere objekt
        //transform.Rotate(0, 10, 0);

        // objekt hüpfen lassen
        transform.Translate(new Vector3(0, jumpVelocity, 0) * Time.deltaTime);
    }
}
