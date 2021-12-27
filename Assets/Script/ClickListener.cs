using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickListener : MonoBehaviour
{

    Renderer sr;

    // 클릭하고 싶은 오브젝트
    public GameObject clickObject;

    // 이지연 사용예정
    public GameObject board, country, content;



    public void btnClick()
    {
        sr = clickObject.GetComponent<Renderer>();

        // 클릭하려는 오브젝트 이름
        string objectName = clickObject.name;

        board = GameObject.Find("explain_board");
        
        if(objectName.Equals("btn1"))
        {
            country.GetComponent<TextMesh>().text = "캐나다";
            content.GetComponent<TextMesh>().text = "- 1.17 ~ 18 : 동부 눈 폭, 적설량 최대 75cm, 최대풍속 150km/h";
            sr.material.color = Color.green;
        } else if (objectName.Equals("btn2"))
        {
            country.GetComponent<TextMesh>().text = "중미/대서양";
            content.GetComponent<TextMesh>().text = "- 11.3 ~ 6 : 최대풍속 225km/h, 허리케인 '에타', 홍수와 산사, 최소 130여명 사망\n";
            sr.material.color = Color.green;
        } else
        {

        }
    }
}
