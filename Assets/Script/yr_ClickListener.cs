using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yr_ClickListener : MonoBehaviour
{
    Renderer sr;

    // Ŭ���ϰ� ���� ������Ʈ
    public GameObject clickObject;

    public GameObject yr_water_point, yr_gas_point;


    private void Start()
    {
        yr_water_point.SetActive(false);
        yr_gas_point.SetActive(false);
       
    }

    public void btn_Click()
    {
        sr = clickObject.GetComponent<Renderer>();

        // Ŭ���Ϸ��� ������Ʈ �̸�
        string objectName = clickObject.name;
        print("������ �ڵ����" + objectName);

        switch (objectName) {
            case "yr_water_power_bt":
                Debug.Log("���¹�ưŬ����");
                yr_water_point.SetActive(true);
                yr_gas_point.SetActive(false);
                break;
            case "yr_gas_bt":
                Debug.Log("������ưŬ����");
                yr_water_point.SetActive(false);
                yr_gas_point.SetActive(true);
                break;

        }
        


      /*  switch (objectName) {
            case "water_power_bt":
             
                break;

        }
*/
/*
        board = GameObject.Find("explain_board");

        if (objectName.Equals("btn1"))
        {
            country.GetComponent<TextMesh>().text = "ĳ����";
            content.GetComponent<TextMesh>().text = "- 1.17 ~ 18 : ���� �� ��, ������ �ִ� 75cm, �ִ�ǳ�� 150km/h";
        }
        else if (objectName.Equals("btn2"))
        {
            country.GetComponent<TextMesh>().text = "�߹�/�뼭��";
            content.GetComponent<TextMesh>().text = "- 11.3 ~ 6 : �ִ�ǳ�� 225km/h, �㸮���� '��Ÿ', ȫ���� ���, �ּ� 130���� ���\n";
        }
        else if (objectName.Equals("btn3"))
        {
            country.GetComponent<TextMesh>().text = "�߹�/�뼭��";
            content.GetComponent<TextMesh>().text = "- 11.3 ~ 6 : �ִ�ǳ�� 225km/h, �㸮���� '��Ÿ', ȫ���� ���, �ּ� 130���� ���\n";
        }*/
    }
}
