using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    // private static EnemyHealth SharedInstance;
    
    public int startingHealth = 120;
    public int mobArmor = 2;
    public int currentHealth;
    private int regenRate = 1;
    public bool mobIsDead = false;

    public int strongMonolith;
    public int viciousMonolith;
    public int goreMonolith;
    public int spiralMonolith;
    public int surveyorMonolith;

    public HealthBar healthbar;
    public GameObject enemyUI;

    void Awake(){
        this.currentHealth = startingHealth;
    }
    

    void Start(){
        
        // SharedInstance =this;
        
        healthbar.SetMaxHealth(startingHealth);
        InvokeRepeating("regeneration", 0, 2);
        mobIsDead = false;

        
        
       
    }
    
    void Update(){
        spawnerMonolith spawner = gameObject.GetComponent<spawnerMonolith>();

        if(gameObject.activeInHierarchy == true){
            mobIsDead = false;
        }

        if(currentHealth >= startingHealth){
            enemyUI.gameObject.SetActive(false);
        }
        healthbar.SetHealth(currentHealth);
        if (currentHealth < startingHealth){
            enemyUI.gameObject.SetActive(true);
        }

        if(currentHealth<= 0){
            enemyUI.gameObject.SetActive(false);
            gameObject.SetActive(false);
            mobIsDead = true;
            
            spawnerMonolith.SharedInstance.counter -= strongMonolith;
            viciousSpawner.SharedInstance.counter -= viciousMonolith;
            GoreMonolithSpawner.SharedInstance.counter -= goreMonolith;
            SpiralMonolithSpawner.SharedInstance.counter -= spiralMonolith;
            SurveyorMonolithSpawner.SharedInstance.counter -= surveyorMonolith;
        }
        
    }

    void regeneration(){
        
        if(this.currentHealth < startingHealth && mobIsDead == false){
            this.currentHealth += regenRate;
            
        }

    }
}
