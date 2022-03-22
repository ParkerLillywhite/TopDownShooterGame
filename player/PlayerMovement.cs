using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float playerSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;
    Vector2 mousePos;
    public Transform cam;

    Vector3 moveRight;
    private CharacterController controller;

    


    // Update is called once per frame
    void Update()
    {
        
        
        //for child
        // mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        
    }

    void FixedUpdate(){
        //for parent
        // rb.MovePosition(rb.position + movement * playerSpeed * Time.fixedDeltaTime);

        Vector2 move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        move = transform.TransformDirection(move);
        
        
        Vector2 camF = cam.up;
        Vector2 camR = cam.right;

        
        camF = camF.normalized;
        camR = camR.normalized;

        

        rb.MovePosition(rb.position + (move.y*camF  + move.x*camR) * playerSpeed * Time.deltaTime);
        
        

        
        
        //for child
        // Vector2 lookDirection = mousePos - rb.position ;
        // //for child
        // float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;
        // //Atan2 finds the angle of a centered point to another.
        // //for child
        // rb.rotation = angle;
    }

    // public void LateUpdate(){
    //     transform.rotation = Quaternion.Lerp(transform.rotation, cam.rotation, 40) ;
    // }
}
