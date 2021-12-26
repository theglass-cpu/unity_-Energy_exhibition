using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yr_bituminous_click : MonoBehaviour
{

    private bool state;
    //���콺�� Ŭ���� ������Ʈ
    private GameObject target;
    private bool mouseState;
    //���콺 ����
    private Vector3 MousePos;
    //���콺 ��ǥ 
    Camera _mainCam = null;

    private GameObject GetClickedObject() {
        //�浹�� ������ ����
        RaycastHit hit;
        //ã�� ������Ʈ
        GameObject target = null;
        //���콺 ����Ʈ ��ó ��ǥ�� �����.
        Ray ray = _mainCam.ScreenPointToRay(Input.mousePosition);
        //���콺 ��ó�� ������Ʈ�� �ִ��� Ȯ��
        if (true == (Physics.Raycast(ray.origin, ray.direction * 10, out hit)))
        {
            //�ִ�!

            //������ ������Ʈ�� �����Ѵ�.
            target = hit.collider.gameObject;
        }

        return target;
    }
 
    



    private void OnMouseDown()
    {

        if (Input.GetMouseButtonDown(0)) {
            print("OnMouseDown ���콺 Ŭ������");
                Debug.Log("��ź������Ŭ��");
      
        }

        //Debug.Log("Ŭ����");
        //Ŭ�������� ���̰� �ϱ� 
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //���콺�� Ŭ����?
        if (true==Input.GetMouseButtonDown(0)) {
           //Ŭ������
            target = GetClickedObject();
            //�� Ŭ���ߴ��� ������ ������
            if (true == target.Equals(gameObject)) {
                mouseState = true;
                //���콺�����ٲ� 
            } else if (true==Input.GetMouseButtonUp(0)) {
                mouseState = false;
                //���콺 �����ٲ�
            }
        }

        if (true==mouseState) {
            transform.localScale = new Vector3(0.5f,0.5f,0.5f);
        }
        else
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }


    }
}
