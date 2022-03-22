using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_Specs : MonoBehaviour
{
    public int damage = 20;


    void OnCollisionEnter2D(Collision2D col){
        gameObject.SetActive(false);
        playerHealth.currentHealth -= damage;
    }


}
