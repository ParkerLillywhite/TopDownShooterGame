using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZone : MonoBehaviour
{
    public SpawnZone spawnZone;

    public float radius = 7;

    public Vector3 PickRandomPoint(){
        
        var point = Random.insideUnitSphere * radius;

        point.z = 0;
        return point;
        

        
    }
}


