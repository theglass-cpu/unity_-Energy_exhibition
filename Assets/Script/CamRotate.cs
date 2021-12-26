using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour
{
    public float rotSpeed = 400f;

    float mx = 0;
    float my = 0;
    // Start is called before the first frame update
    

    
    void Start()
    {
        Cursor.visible = false; //마우스 커서 숨기기
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouse_X = Input.GetAxis("Mouse X");
        float mouse_Y = Input.GetAxis("Mouse Y");

        mx += mouse_X * rotSpeed * Time.deltaTime;
        my += mouse_Y * rotSpeed * Time.deltaTime;

        my = Mathf.Clamp(my, -90f, 90f);

        //Vector3 dir = new Vector3(-mouse_Y, mouse_X, 0);//방향

        //transform.eulerAngles += dir*rotSpeed*Time.deltaTime;

        //Vector3 rot = transform.eulerAngles;

        //rot.x = Mathf.Clamp(rot.x, -90f, 90f);

        transform.eulerAngles = new Vector3(-my,mx,0);




    }
}
