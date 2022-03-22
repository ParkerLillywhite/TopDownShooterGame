using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPool : MonoBehaviour
{
    public static TestPool SharedInstance;
    public List<GameObject> pooledObjects;
    public GameObject objectToPool;
    public int amountToPool;

    void Awake(){
        SharedInstance = this;
    }

    void Start(){
        pooledObjects = new List<GameObject>();
        GameObject obj;
        for(int i = 0; i < amountToPool; i++){
            obj = Instantiate(objectToPool);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }

        
    }
    public GameObject GetPooledObject(){
            for(int i=0; i < amountToPool; i++){
                if(pooledObjects[i].activeInHierarchy){
                    return pooledObjects[i];
                }
            }
            return null;
        }
}
