using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    public int startingHealth = 100;                            // The amount of health the player starts the game with.
    public int currentHealth;                                   // The current health the player has.
    public Slider healthSlider;                                 // Reference to the UI's health bar.

    bool isDead;                                                // Whether the player is dead.
    bool damaged;                                               // True when the player gets damaged.

    // Use this for initialization
    void Start () {
        currentHealth = startingHealth;
		
	}
	
	// Update is called once per frame
	void Update () {
        
		
	}

    public void TakeDamage(int amount)
    {
        damaged = true;
        currentHealth -= amount; // Reduce the current health by the damage amount.

        // If the player has lost all it's health
        if (currentHealth <= 0)
        {
            // ... it should die.
            //Death();
        }

        // Set the health bar's value to the current health.
        healthSlider.value = currentHealth;
    }
}
