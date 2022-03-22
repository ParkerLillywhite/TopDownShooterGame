using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aimer : MonoBehaviour
{
    public Vector2 enemy;
    public Rigidbody2D rb;
    public Transform player;

    void FixedUpdate(){
        
        Vector3 dir = player.position - transform.position;
        float angle = Mathf.Atan2(dir.y,dir.x) * Mathf.Rad2Deg -90;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
