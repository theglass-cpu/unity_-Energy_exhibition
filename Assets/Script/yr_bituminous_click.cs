using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yr_bituminous_click : MonoBehaviour
{

    private bool state;
    //마우스가 클릭한 오브젝트
    private GameObject target;
    private bool mouseState;
    //마우스 상태
    private Vector3 MousePos;
    //마우스 좌표 
    Camera _mainCam = null;

    private GameObject GetClickedObject() {
        //충돌이 감지된 영역
        RaycastHit hit;
        //찾은 오브젝트
        GameObject target = null;
        //마우스 포이트 근처 좌표를 만든다.
        Ray ray = _mainCam.ScreenPointToRay(Input.mousePosition);
        //마우스 근처에 오브젝트가 있는지 확인
        if (true == (Physics.Raycast(ray.origin, ray.direction * 10, out hit)))
        {
            //있다!

            //있으면 오브젝트를 저장한다.
            target = hit.collider.gameObject;
        }

        return target;
    }
 
    



    private void OnMouseDown()
    {

        if (Input.GetMouseButtonDown(0)) {
            print("OnMouseDown 마우스 클릭했음");
                Debug.Log("연탄발전소클릭");
      
        }

        //Debug.Log("클릭함");
        //클릭했을때 보이게 하기 
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //마우스가 클릭함?
        if (true==Input.GetMouseButtonDown(0)) {
           //클릭했음
            target = GetClickedObject();
            //뭘 클릭했는지 정보를 가져옴
            if (true == target.Equals(gameObject)) {
                mouseState = true;
                //마우스정보바꿈 
            } else if (true==Input.GetMouseButtonUp(0)) {
                mouseState = false;
                //마우스 정보바꿈
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
