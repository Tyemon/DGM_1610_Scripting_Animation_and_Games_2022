using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    public float deathDelay;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int dmgAmount)
    {
        currentHealth -= dmgAmount; //Take away a certain amount of healths

        if(currentHealth <= 0)
        {
            Debug.Log("Player has died! Game over!");
               // Destroy(gameObject,deathDelay); //Check if Player Died
            Time.timeScale = 0f;

        }
    }

    public void AddHealth(int healAmount)
{
    if(currentHealth <= 0)
    {
        currentHealth += healAmount;

        if(currentHealth >= maxHealth)
        {
            currentHealth = maxHealth; //Make sure that current health does not exceed max health
        }
    }
}
}
