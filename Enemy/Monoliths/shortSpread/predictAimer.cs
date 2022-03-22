using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class predictAimer : MonoBehaviour
{
    public Vector2 enemy;
    public Rigidbody2D rb;
    public Transform players;
    


    // public GameObject FindClosestPlayer(){
    //     GameObject[] players;
    //     players = GameObject.FindGameObjectsWithTag("player");
        
    //     Vector3 position = transform.position;
    //     foreach( GameObject plyr in players){
    //         Vector3 target = plyr.transform.position;
    //         return target;
    //     }
    // }

    void FixedUpdate(){
        
        players = GameObject.FindWithTag("player").transform;
        
        Vector3 dir = players.transform.position - transform.position;
        float angle = Mathf.Atan2(dir.y,dir.x) * Mathf.Rad2Deg -90;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
