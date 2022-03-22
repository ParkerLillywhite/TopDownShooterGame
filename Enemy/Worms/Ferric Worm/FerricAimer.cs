using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FerricAimer : MonoBehaviour
{
     public Transform firePoint;
     public Transform firePoint2;
     public Transform firePoint3;
     public Transform firePoint4;
     public Transform firePoint5;
     public Transform firePoint6;
    
    public Transform players;
    public Transform enemy;

    public float bulletForce = 3f;
    public float secondaryBulletForce = 3f;

    private Vector3 distance;
    private float distanceFrom;

    private float eyeSight = 5;
    public float timer = 0.0f;

    private float bulletPause = 0;




    void Update(){
        players = GameObject.FindWithTag("player").transform;
        distance = (enemy.position - players.transform.position);
        distanceFrom = distance.magnitude;

       timer -= 1 * Time.deltaTime;
  

       if(timer<=0){
           timer += 0.5f;
           if (distanceFrom < eyeSight){
                Shoot();
                Shoot2();
                Shoot3();
                Shoot4();
                Shoot5();
                Shoot6();
                // bulletPause += 1;
           }
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
        GameObject bullet = FW_bulletPool.SharedInstance.GetPooledObject();
            if (bullet != null){
                bullet.transform.position = firePoint.transform.position;
                
                bullet.transform.rotation = firePoint.transform.rotation;
                bullet.transform.rotation *= Quaternion.Euler(0, 0, 90);
                
                bullet.SetActive(true);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
                StartCoroutine(bulletRadius());
            }
        IEnumerator bulletRadius(){
        yield return new WaitForSeconds(0.5f);
        bullet.SetActive(false);
    }
        
    }
    void Shoot2(){
        GameObject bullet = FW_bulletPool.SharedInstance.GetPooledObject();
            if (bullet != null){
                bullet.transform.position = firePoint2.position;
                bullet.transform.rotation = firePoint2.rotation;
                bullet.transform.rotation *= Quaternion.Euler(0, 0, 90);
                bullet.SetActive(true);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint2.up * bulletForce, ForceMode2D.Impulse);
                StartCoroutine(bulletRadius());
            }
        IEnumerator bulletRadius(){
        yield return new WaitForSeconds(1);
        bullet.SetActive(false);
    }
        
    }
    void Shoot3(){
        GameObject bullet = FW_bulletPool.SharedInstance.GetPooledObject();
            if (bullet != null){
                bullet.transform.position = firePoint3.position;
                bullet.transform.rotation = firePoint3.rotation;
                bullet.transform.rotation *= Quaternion.Euler(0, 0, 90);
                bullet.SetActive(true);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint3.up * bulletForce, ForceMode2D.Impulse);
                StartCoroutine(bulletRadius());
            }
        IEnumerator bulletRadius(){
        yield return new WaitForSeconds(1);
        bullet.SetActive(false);
        }
    }

    void Shoot4(){
        GameObject bullet = FW_bulletPool.SharedInstance.GetPooledObject();
            if (bullet != null){
                bullet.transform.position = firePoint4.position;
                bullet.transform.rotation = firePoint4.rotation;
                bullet.transform.rotation *= Quaternion.Euler(0, 0, 90);
                bullet.SetActive(true);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint4.up * bulletForce, ForceMode2D.Impulse);
                StartCoroutine(bulletRadius());
            }
        IEnumerator bulletRadius(){
        yield return new WaitForSeconds(1);
        bullet.SetActive(false);
        }
    }

    void Shoot5(){
        GameObject bullet = FW_bulletPool.SharedInstance.GetPooledObject();
            if (bullet != null){
                bullet.transform.position = firePoint5.position;
                bullet.transform.rotation = firePoint5.rotation;
                bullet.transform.rotation *= Quaternion.Euler(0, 0, 90);
                bullet.SetActive(true);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint5.up * bulletForce, ForceMode2D.Impulse);
                StartCoroutine(bulletRadius());
            }
        IEnumerator bulletRadius(){
        yield return new WaitForSeconds(1);
        bullet.SetActive(false);
        }
    }
    void Shoot6(){
        GameObject bullet = FW_bulletPool.SharedInstance.GetPooledObject();
            if (bullet != null){
                bullet.transform.position = firePoint6.position;
                bullet.transform.rotation = firePoint6.rotation;
                bullet.transform.rotation *= Quaternion.Euler(0, 0, 90);
                bullet.SetActive(true);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint6.up * bulletForce, ForceMode2D.Impulse);
                StartCoroutine(bulletRadius());
            }
        IEnumerator bulletRadius(){
        yield return new WaitForSeconds(1);
        bullet.SetActive(false);
        }
    }


}
