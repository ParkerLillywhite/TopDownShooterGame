using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spiral_Aimer : MonoBehaviour
{
     public Transform firePoint;
     public Transform firePoint2;
     public Transform firePoint3;
     public Transform firePoint4;
     public Transform firePoint5;
     public Transform firePoint6;
     public Transform firePoint7;
    public Transform firePoint8;

    public Transform players;
    public Transform enemy;
    public bool isAttacking;
    public float bulletForce = 3f;
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
           timer += 0.2f;
           if (distanceFrom < eyeSight && bulletPause == 0){
                Shoot();
                bulletPause += 1;
           }
           else if (distanceFrom < eyeSight && (bulletPause == 1)){
                Shoot2();
                bulletPause += 1;
           }
           else if (distanceFrom < eyeSight && bulletPause == 2){
                Shoot3();
                bulletPause += 1;
           }
           else if (distanceFrom < eyeSight && bulletPause == 3){
                Shoot4();
                bulletPause += 1;
           }
           else if (distanceFrom < eyeSight && bulletPause == 4){
                Shoot5();
                bulletPause += 1;
           }
           else if (distanceFrom < eyeSight && bulletPause == 5){
                Shoot6();
                bulletPause += 1;
           }
           else if (distanceFrom < eyeSight && bulletPause == 6){
                Shoot7();
                bulletPause += 1;
           }
           else if (distanceFrom < eyeSight && bulletPause == 7){
                Shoot8();
                bulletPause += 1;
           }

        }
        
       if (bulletPause == 8){
           timer +=1.5f;
           bulletPause -= 8;
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
        GameObject bullet = S_bulletPool.SharedInstance.GetPooledObject();
            if (bullet != null){
                bullet.transform.position = firePoint.transform.position;
                bullet.transform.rotation = firePoint.transform.rotation;
                bullet.SetActive(true);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
                StartCoroutine(bulletRadius());
            }
        IEnumerator bulletRadius(){
        yield return new WaitForSeconds(5);
        bullet.SetActive(false);
    }
        
    }
    void Shoot2(){
        GameObject bullet = S_bulletPool.SharedInstance.GetPooledObject();
            if (bullet != null){
                bullet.transform.position = firePoint2.position;
                bullet.transform.rotation = firePoint2.rotation;
                bullet.SetActive(true);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint2.up * bulletForce, ForceMode2D.Impulse);
                StartCoroutine(bulletRadius());
            }
        IEnumerator bulletRadius(){
        yield return new WaitForSeconds(3);
        bullet.SetActive(false);
    }
        
    }
    void Shoot3(){
        GameObject bullet = S_bulletPool.SharedInstance.GetPooledObject();
            if (bullet != null){
                bullet.transform.position = firePoint3.position;
                bullet.transform.rotation = firePoint3.rotation;
                bullet.SetActive(true);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint3.up * bulletForce, ForceMode2D.Impulse);
                StartCoroutine(bulletRadius());
            }
        IEnumerator bulletRadius(){
        yield return new WaitForSeconds(4);
        bullet.SetActive(false);
        }
    }

    void Shoot4(){
        GameObject bullet = S_bulletPool.SharedInstance.GetPooledObject();
            if (bullet != null){
                bullet.transform.position = firePoint4.position;
                bullet.transform.rotation = firePoint4.rotation;
                bullet.SetActive(true);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint4.up * bulletForce, ForceMode2D.Impulse);
                StartCoroutine(bulletRadius());
            }
        IEnumerator bulletRadius(){
        yield return new WaitForSeconds(3);
        bullet.SetActive(false);
        }
    }

    void Shoot5(){
        GameObject bullet = S_bulletPool.SharedInstance.GetPooledObject();
            if (bullet != null){
                bullet.transform.position = firePoint5.position;
                bullet.transform.rotation = firePoint5.rotation;
                bullet.SetActive(true);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint5.up * bulletForce, ForceMode2D.Impulse);
                StartCoroutine(bulletRadius());
            }
        IEnumerator bulletRadius(){
        yield return new WaitForSeconds(3);
        bullet.SetActive(false);
        }
    }

    void Shoot6(){
        GameObject bullet = S_bulletPool.SharedInstance.GetPooledObject();
            if (bullet != null){
                bullet.transform.position = firePoint5.position;
                bullet.transform.rotation = firePoint5.rotation;
                bullet.SetActive(true);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint6.up * bulletForce, ForceMode2D.Impulse);
                StartCoroutine(bulletRadius());
            }
        IEnumerator bulletRadius(){
        yield return new WaitForSeconds(3);
        bullet.SetActive(false);
        }
    }

    void Shoot7(){
        GameObject bullet = S_bulletPool.SharedInstance.GetPooledObject();
            if (bullet != null){
                bullet.transform.position = firePoint5.position;
                bullet.transform.rotation = firePoint5.rotation;
                bullet.SetActive(true);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint7.up * bulletForce, ForceMode2D.Impulse);
                StartCoroutine(bulletRadius());
            }
        IEnumerator bulletRadius(){
        yield return new WaitForSeconds(3);
        bullet.SetActive(false);
        }
    }

    void Shoot8(){
        GameObject bullet = S_bulletPool.SharedInstance.GetPooledObject();
            if (bullet != null){
                bullet.transform.position = firePoint5.position;
                bullet.transform.rotation = firePoint5.rotation;
                bullet.SetActive(true);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint8.up * bulletForce, ForceMode2D.Impulse);
                StartCoroutine(bulletRadius());
            }
        IEnumerator bulletRadius(){
        yield return new WaitForSeconds(3);
        bullet.SetActive(false);
        }
    }
}
