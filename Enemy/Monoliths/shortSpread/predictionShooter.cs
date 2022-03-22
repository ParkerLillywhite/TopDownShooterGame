using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class predictionShooter : MonoBehaviour
{
     public Transform firePoint;
     public Transform firePoint2;
     public Transform firePoint3;
    public GameObject bulletPrefab;
    public Transform players;
    public Transform enemy;
    public bool isAttacking;
    public float bulletForce = 8f;

    private Vector3 distance;
    private float distanceFrom;
    private bool canShoot = false;
    private float eyeSight = 10;
    public float timer = 1.0f;

    void Start(){
        
        isAttacking = false;
        // StartCoroutine(Fire());

    }

    void Update(){
        players = GameObject.FindWithTag("player").transform;
        distance = (enemy.position - players.transform.position);
        distanceFrom = distance.magnitude;

       timer -= 1 * Time.deltaTime;

       if(timer<=0){
           timer += 1.0f;
           if (distanceFrom < eyeSight){
                Shoot();
                Shoot2();
                Shoot3();
           }
            
       }

        if (distanceFrom < eyeSight && timer == 1.0 ) {
            canShoot = true;
            
            isAttacking = true;
            

        } 

        
        
        
        if(distanceFrom >= eyeSight){
            canShoot = false;
            isAttacking = false;
        }
        


        
    }

    // IEnumerator Fire(){
        
    //     while(true){
    //         if(canShoot == true){
    //             Shoot();
    //             Shoot2();
    //             Shoot3();
    //         }
            
            
    //     }
    //     yield return new WaitForSeconds (1);
    //     canShoot = false;
    // }

    

    void Shoot(){
        // GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        GameObject bullet = SSE_bulletPool.SharedInstance.GetPooledObject();
            if (bullet != null){
                bullet.transform.position = firePoint.transform.position;
                bullet.transform.rotation = firePoint.transform.rotation;
                bullet.SetActive(true);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
                StartCoroutine(bulletRadius());
            }
        IEnumerator bulletRadius(){
        yield return new WaitForSeconds(1);

        bullet.SetActive(false);
    }
        
    }
    void Shoot2(){
        GameObject bullet = SSE_bulletPool.SharedInstance.GetPooledObject();
            if (bullet != null){
                bullet.transform.position = firePoint2.position;
                bullet.transform.rotation = firePoint2.rotation;
                bullet.SetActive(true);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
                StartCoroutine(bulletRadius());
            }
        IEnumerator bulletRadius(){
        yield return new WaitForSeconds(1);
        bullet.SetActive(false);
    }
        
    }
    void Shoot3(){
        GameObject bullet = SSE_bulletPool.SharedInstance.GetPooledObject();
            if (bullet != null){
                bullet.transform.position = firePoint3.position;
                bullet.transform.rotation = firePoint3.rotation;
                bullet.SetActive(true);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
                StartCoroutine(bulletRadius());
            }
        IEnumerator bulletRadius(){
        yield return new WaitForSeconds(1);
        bullet.SetActive(false);
    }
    }
}
