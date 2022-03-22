using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mobSpawner : MonoBehaviour
{
    public Transform point;

    void Update(){
        Spawn();
    }

    public void Spawn(){
        GameObject harmless = TestPool.SharedInstance.GetPooledObject();
            if(harmless != null){
                harmless.transform.position = point.position;
                harmless.transform.rotation = point.rotation;
                harmless.SetActive(true);
            }
    }
}
