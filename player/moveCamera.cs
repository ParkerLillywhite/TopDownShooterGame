using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{

    public Transform followTransform;


    


   
    // Update is called once per frame
    void LateUpdate()
    {
        this.transform.position = new Vector3(followTransform.position.x, followTransform.position.y, this.transform.position.z);
        if(Input.GetKey("e")){
            transform.Rotate(new Vector3(0, 0, -1));
        }
        if(Input.GetKey("q")){
            transform.Rotate(new Vector3(0, 0, 1));
        }
        
    }
}