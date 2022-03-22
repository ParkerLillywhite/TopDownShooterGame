using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camRotation : MonoBehaviour
{
    private float playerSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;
    Vector2 mousePos;
    public Camera cam;
    public Transform player;

    void Update(){
       mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        
    }

    void LateUpdate(){
        Vector2 lookDirection = mousePos - rb.position ;
        //for child
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;
        //Atan2 finds the angle of a centered point to another.
        //for child
        rb.rotation = angle;

        this.transform.position = player.position;
    }
}
