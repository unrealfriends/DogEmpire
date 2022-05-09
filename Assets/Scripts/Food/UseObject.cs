using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseObject : MonoBehaviour
{
    //public Health health;
    //increaseHealth = new IncreaseHealth();
    int foodGain = 5;
    public FoodAI foodAI;

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
            Pickup(foodGain);
            //AddToHealth();
        }
    }

    void Pickup(int foodGain)
    {
        foodGain = this.foodGain;
        // effekt auf player anwenden

        // objekt entfernen
        Destroy(gameObject);
        Debug.Log("Objekt wurde berührt");
        foodAI.FoodPickedUp(foodGain);
    }
}
