using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snakeMovement : MonoBehaviour
{

    public List<Transform> bodyParts = new List<Transform>();
    public float minDistance = 2f;
    public float curspeed = 3;
    private Transform curBodyPart;
    private Transform PrevBodyPart;

    private Vector3 newpos;

    private float dis;

    void Update(){
        Move();
    }


    public void Move(){
        for (int i = 1; i < bodyParts.Count; i++){
            curBodyPart = bodyParts[i];
            PrevBodyPart = bodyParts[i -1];

            dis = Vector3.Distance(PrevBodyPart.position, curBodyPart.position);

            Vector3 newpos = PrevBodyPart.position;
            newpos.z = bodyParts[0].position.z;
            
            float speed = Time.deltaTime * dis /minDistance * curspeed;

            if(speed > 0.5f){
                speed = 0.5f;
            }

            curBodyPart.position = Vector3.Slerp(curBodyPart.position, newpos, speed);
            curBodyPart.rotation = Quaternion.Slerp(curBodyPart.rotation, PrevBodyPart.rotation, speed);
        }
    }
}
