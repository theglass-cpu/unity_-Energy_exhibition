using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float moveSpeed = 10000f;//이동속도 변수

    public float jumpPower = 10f;

    public bool isJumping = false;

    CharacterController cc;

    //중력변수
    float gravity = -20f;

    //수직 속력 변수
    float yVelocity = 0;

    private void Start()
    {
        cc = GetComponent<CharacterController>();
    }


    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h,0,v);

        dir = dir.normalized;

        dir = Camera.main.transform.TransformDirection(dir);


        //점프 중이고, 바닥에 착지한다면 점프 전 상태로 초기화
        if (isJumping && cc.collisionFlags == CollisionFlags.Below)
        {
            isJumping = false;
            yVelocity = 0;
        }
        
        //스페이바를 눌렀고, 점프하지 않은 상태면 점프 상태로 변경
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            yVelocity = jumpPower;
            isJumping=true;

        }

        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;

        cc.Move(dir * moveSpeed *Time.deltaTime);

        //transform.position += dir * moveSpeed * Time.deltaTime;
    }
}
