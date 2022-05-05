using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    // maximale gesundheit und momentane gesundheit zuweisen
    public int maxHealth = 100;
    public int currentHealth;

    //losinghealth auf false, sonst verliert von anfang an gesundheit
    public bool losingHealth = false;

    // healthbar aufrufen
    // da gesundheit direkt mit healthbar interagiert
    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {

        losingHealth = true;
        // bei start: momentane gesundheit ist gleich maximale 
        currentHealth = maxHealth;
        // healthbar entsprechend anpassen
        healthBar.SetMaxHealth(maxHealth);

        if (losingHealth == true)
        {
            StartCoroutine(UpdateHealth());

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator UpdateHealth()
    {
        while (true)
        {
            // 5 sekunden warten
            yield return new WaitForSeconds(5f);
            // gesundheit abziehen
            DecreaseHealth();
        }
    }

    void DecreaseHealth()
    {
        // 1 punkt gesundheit abziehen
        currentHealth = currentHealth - 1;

        // healthbar auf aktuellen wert setzen (slider anpassen)
        healthBar.SetHealth(currentHealth);
    }
}
