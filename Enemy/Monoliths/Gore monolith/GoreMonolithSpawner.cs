using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoreMonolithSpawner : MonoBehaviour
{
    public static GoreMonolithSpawner SharedInstance;
    public Transform point;
    public Transform[] spawnpoints;
   
    public int counter = 0;
    private int num;
    private int spawnIndex;
    

    void Awake(){
        SharedInstance = this;
    }

    void Start(){
        num = transform.childCount;
        spawnpoints = new Transform[num];
        for (int i =0; i < num; i++){
            spawnpoints[i] = transform.GetChild(i);
        }
    }
   

    void Update(){
        
        if (counter <4){
            Spawn();
            counter +=1;
        }

        
    }

    

    void Spawn(){  
        GameObject monolith = GoreMonolithPool.SharedInstance.GetPooledObject();
        
        spawnIndex = Random.Range(0, num);

        if(monolith != null){
            monolith.transform.position = spawnpoints[spawnIndex].position;
            monolith.transform.rotation = spawnpoints[spawnIndex].rotation;
            EnemyHealth health = monolith.gameObject.GetComponent<EnemyHealth>();
            health.currentHealth = health.startingHealth;
       
            monolith.SetActive(true);
        }
    }

    // void Update(){
    //     if (counter <= 3){
    //         StartCoroutine(spawnInterval());
    //     }
    // }


}
