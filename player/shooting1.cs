using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting1 : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    

    public float bulletForce = 20f;
    public bool bulletIsAlive = false;

    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            Shoot();
        }
        
    }

    public void Shoot(){
        // GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        GameObject bullet = ObjectPool.SharedInstance.GetPooledObject();
            if(bullet != null){
                bullet.transform.position = firePoint.transform.position;
                bullet.transform.rotation = firePoint.transform.rotation;
                bullet.SetActive(true);
                bulletIsAlive = true;
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
                StartCoroutine(bulletRadius());
            }
        
        IEnumerator bulletRadius(){
            yield return new WaitForSeconds(1);
            bullet.SetActive(false);
            bulletIsAlive = false;
            StopCoroutine(bulletRadius());
            
        }
    }

    

    
}