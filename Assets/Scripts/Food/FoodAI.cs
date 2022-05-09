using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodAI : MonoBehaviour
{
    // maximale gesundheit und momentane gesundheit zuweisen
    public int maxFood = 100;
    public int currentFood;

    //losinghealth auf false, sonst verliert von anfang an gesundheit
    public bool losingFood;
    // startcoroutine auf false, sonst starten couroutines mit jedem frame
    public bool coroutineStart = false;

    // foodbar aufrufen
    // da gesundheit direkt mit foodbar interagiert
    public FoodBar foodBar;
    public HealthBar healthBar;

    public Health health;

    // Start is called before the first frame update
    void Start()
    {
        //GameObject gameObject = new GameObject("Health");
        //health = gameObject.AddComponent<Health>();

        losingFood = true;
        // bei start: momentane gesundheit ist gleich maximale 
        currentFood = maxFood;
        // healthbar entsprechend anpassen
        foodBar.SetMaxFood(maxFood);

        if (losingFood == true)
        {
            StartCoroutine(UpdateFood());

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (currentFood <= 90 && coroutineStart == false)
        {
            print("Nahrung ist knapp! Bitte Essen!");

            health.losingHealth = true;
            StartCoroutine(health.UpdateHealth());
            coroutineStart = true;
        }

    }

    IEnumerator UpdateFood()
    {
        while (true)
        {
            // 5 sekunden warten
            yield return new WaitForSeconds(5f);
            // gesundheit abziehen
            DecreaseFood();
        }
    }

    void DecreaseFood()
    {
        // 1 punkt gesundheit abziehen
        currentFood = currentFood - 2;

        // foodbar auf aktuellen wert setzen (slider anpassen)
        foodBar.SetFood(currentFood);
    }
}
