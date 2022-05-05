using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseObject : MonoBehaviour
{
    //public Health health;
    //increaseHealth = new IncreaseHealth();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup();
            //AddToHealth();
        }
    }

    void Pickup()
    {
        Debug.Log("Power up picked up!");

        // effekt auf player anwenden

        // objekt entfernen
        Destroy(gameObject);
        print("Objekt wurde berührt");
    }
}
