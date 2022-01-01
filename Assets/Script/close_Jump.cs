using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class close_Jump : MonoBehaviour
{
    public Transform other;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        room_jump();
    }
    public void room_jump() {
       

       
        float distance = Vector3.Distance(other.position, transform.position);

        if (distance < 50f)
        {
            GameObject.Find("Main Camera").GetComponent<Scene_Jumping>().Jump();

        }


        //print("다른 사람과의 거리: " + distance);

    }
}
