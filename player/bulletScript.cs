using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    // public GameObject hitEffect;
    public GameObject player;

    private float bulletTime = 1f;

    public int bulletDamage = 10;

    

    void OnCollisionEnter2D(Collision2D collision){

        if(collision.gameObject.tag == "mob"){
            // EnemyHealth.SharedInstance.currentHealth -= bulletDamage;
            EnemyHealth enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
            shooting1 shooting = gameObject.GetComponentInParent<shooting1>();
            
        
            gameObject.SetActive(false);
            

            if(enemyHealth != null){
                enemyHealth.currentHealth -= bulletDamage;
                
            }
        }

        if(collision.gameObject.tag == "snakeBody"){
            EnemyHealth enemyHealth = collision.gameObject.GetComponentInParent<EnemyHealth>();

            gameObject.SetActive(false);

            if(enemyHealth != null){
                enemyHealth.currentHealth -= bulletDamage;
            }
        }

    }
}
