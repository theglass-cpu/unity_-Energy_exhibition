using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float moveSpeed = 10000f;//�̵��ӵ� ����

    public float jumpPower = 10f;

    public bool isJumping = false;

    CharacterController cc;

    //�߷º���
    float gravity = -20f;

    //���� �ӷ� ����
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


        //���� ���̰�, �ٴڿ� �����Ѵٸ� ���� �� ���·� �ʱ�ȭ
        if (isJumping && cc.collisionFlags == CollisionFlags.Below)
        {
            isJumping = false;
            yVelocity = 0;
        }
        
        //�����̹ٸ� ������, �������� ���� ���¸� ���� ���·� ����
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
