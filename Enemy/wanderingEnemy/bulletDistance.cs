using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDistance : MonoBehaviour
{
    public int damage = 20;
   
    
    void OnCollisionEnter2D(Collision2D collision){
        gameObject.SetActive(false);
        playerHealth.currentHealth -= damage;

    }

    

    
}
