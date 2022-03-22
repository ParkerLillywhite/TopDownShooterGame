using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormStrike : MonoBehaviour
{
    private Rigidbody2D[] childArray;
    public Transform target;
	public Transform enemy;
	private Vector3 distance;
	private float distanceFrom;
    public float attackRange = 2;

    void FixedUpdate(){
        Rigidbody2D[] childArray = GetComponentsInChildren<Rigidbody2D>();

        target = GameObject.FindWithTag("player").transform;
        
        distance = (enemy.position - target.position);
        distanceFrom = distance.magnitude;
        if(distanceFrom < attackRange){
            
            Rigidbody2D rb2D = gameObject.GetComponent<Rigidbody2D>();
            rb2D.AddForce(transform.up * 10000, ForceMode2D.Impulse);
            
        }
        
    }
}
