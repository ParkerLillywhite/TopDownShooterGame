using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public static int currentHealth;
    public int regenRate = 1;
    public bool playerIsDead = false;

    public HealthBar healthbar;


    void Start(){
        currentHealth = startingHealth;
        healthbar.SetMaxHealth(startingHealth);
        InvokeRepeating("regeneration", 0, 1);

       
    }
    
    void Update(){
        healthbar.SetHealth(currentHealth);

        if(currentHealth<= 0){
            playerIsDead = true;
        }
    }

    void regeneration(){
        
        if(currentHealth < startingHealth && playerIsDead == false){
            currentHealth += regenRate;
            
        }
            
        
            
            
            
            
    }

    

    
    
}
