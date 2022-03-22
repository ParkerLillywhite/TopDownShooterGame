using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class viciousAimer : MonoBehaviour
{
     public Transform firePoint;
     public Transform firePoint2;
     public Transform firePoint3;
     public Transform firePoint4;
     public Transform firePoint5;
    
    public Transform players;
    public Transform enemy;
    public bool isAttacking;
    public float bulletForce = 8f;
    public float secondaryBulletForce = 3f;

    private Vector3 distance;
    private float distanceFrom;
    private bool canShoot = false;
    private float eyeSight = 8;
    public float timer = 0.0f;
    private float secondaryTimer = 0.0f;
    private float bulletPause = 0;


    void Start(){
        
        isAttacking = false;
        // StartCoroutine(Fire());

    }

    void Update(){
        players = GameObject.FindWithTag("player").transform;
        distance = (enemy.position - players.transform.position);
        distanceFrom = distance.magnitude;

       timer -= 1 * Time.deltaTime;
       secondaryTimer -= 1 * Time.deltaTime;

       if(timer<=0){
           timer += 0.1f;
           if (distanceFrom < eyeSight){
                Shoot();
                bulletPause += 1;
           }
        }
       if (bulletPause == 4){
           timer +=1.5f;
           bulletPause =0;
        }

        if (secondaryTimer <= 0){
            secondaryTimer += 3.0f;
            if(distanceFrom < eyeSight){
                Shoot2();
                Shoot3();
                Shoot4();
                Shoot5();
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
        GameObject bullet = VM_bulletPool.SharedInstance.GetPooledObject();
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
        GameObject bullet = VMB_bulletPool.SharedInstance.GetPooledObject();
            if (bullet != null){
                bullet.transform.position = firePoint2.position;
                bullet.transform.rotation = firePoint2.rotation;
                bullet.SetActive(true);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint2.up * secondaryBulletForce, ForceMode2D.Impulse);
                StartCoroutine(bulletRadius());
            }
        IEnumerator bulletRadius(){
        yield return new WaitForSeconds(4);
        bullet.SetActive(false);
    }
        
    }
    void Shoot3(){
        GameObject bullet = VMB_bulletPool.SharedInstance.GetPooledObject();
            if (bullet != null){
                bullet.transform.position = firePoint3.position;
                bullet.transform.rotation = firePoint3.rotation;
                bullet.SetActive(true);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint3.up * secondaryBulletForce, ForceMode2D.Impulse);
                StartCoroutine(bulletRadius());
            }
        IEnumerator bulletRadius(){
        yield return new WaitForSeconds(4);
        bullet.SetActive(false);
        }
    }

    void Shoot4(){
        GameObject bullet = VMB_bulletPool.SharedInstance.GetPooledObject();
            if (bullet != null){
                bullet.transform.position = firePoint4.position;
                bullet.transform.rotation = firePoint4.rotation;
                bullet.SetActive(true);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint4.up * secondaryBulletForce, ForceMode2D.Impulse);
                StartCoroutine(bulletRadius());
            }
        IEnumerator bulletRadius(){
        yield return new WaitForSeconds(4);
        bullet.SetActive(false);
        }
    }

    void Shoot5(){
        GameObject bullet = VMB_bulletPool.SharedInstance.GetPooledObject();
            if (bullet != null){
                bullet.transform.position = firePoint5.position;
                bullet.transform.rotation = firePoint5.rotation;
                bullet.SetActive(true);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint5.up * secondaryBulletForce, ForceMode2D.Impulse);
                StartCoroutine(bulletRadius());
            }
        IEnumerator bulletRadius(){
        yield return new WaitForSeconds(4);
        bullet.SetActive(false);
        }
    }
}
