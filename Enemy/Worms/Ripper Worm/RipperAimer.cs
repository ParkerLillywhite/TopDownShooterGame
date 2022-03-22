using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RipperAimer : MonoBehaviour
{
     public Transform firePoint;

    
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
           timer += 0.7f;
           if (distanceFrom < eyeSight){
                Shoot();

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
        GameObject bullet = RW_bulletPool.SharedInstance.GetPooledObject();
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
        



}
