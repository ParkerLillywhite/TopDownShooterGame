using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public Transform player;
    public Transform enemy;
    public bool isAttacking;
    public float bulletForce = 4f;

    private Vector3 distance;
    private float distanceFrom;
    private bool canShoot = false;
    private float eyeSight = 10;

    void Start(){
        
        isAttacking = false;

    }

    void FixedUpdate(){
        distance = (enemy.position - player.position);
        distanceFrom = distance.magnitude;

        if ((distanceFrom < eyeSight) && (!canShoot)){
            StartCoroutine(Fire());
            isAttacking = true;
        } 
        if(distanceFrom >= eyeSight){
            return;
            isAttacking = false;
        }


        
    }

    IEnumerator Fire(){
        canShoot = true;
        Shoot();
        yield return new WaitForSeconds (1);
        canShoot = false;
    }

    void Shoot(){
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
