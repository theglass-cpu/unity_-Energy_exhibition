using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClick : MonoBehaviour
{
    // Start is called before the first frame update


    public Transform point;

    void Start()
    {
        try {
            GameObject.Find("hj_renewable_btn").GetComponent<hj_PowerPlantClick>().InitPowerPlant();//hojae

        }
        catch (Exception ex) { }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(point.position);

            if (Physics.Raycast(ray, out hit, 1000.0f))
            {
                if (hit.transform != null)
                {
                    PrintName(hit.transform.gameObject);
                    string a = hit.transform.name;
                    // print("�� ���� �޼���" + a);
                    // Debug.Log("��ħ?"+a);
                    string[] obj_name = a.Split('_');
                    try
                    {
                        switch (obj_name[0])
                        {
                            case "yr":
                                // Debug.Log("����������" );
                                GameObject.Find(a).GetComponent<yr_ClickListener>().btn_Click();
                                break;

                            case "sh":
                                // Debug.Log("��������");
                                break;


                            case "hj":
                                // Debug.Log("ȣ������");
                                if (a == "hj_renewable_btn" || a == "hj_coal_btn" || a == "hj_nuclear_btn")
                                {
                                    GameObject.Find(a).GetComponent<hj_PowerPlantClick>().clickPowerPlantButton(a);
                                }
                                else if (a == "hj_america_btn" || a == "hj_eu_btn")
                                {
                                    GameObject.Find(a).GetComponent<hj_PowerPlantClick>().ClickGreenNewDealBtn(a);
                                }
                                break;

                            case "jy":
                                // Debug.Log("��������");
                                GameObject.Find(a).GetComponent<jy_ClickListener>().btnClick();
                                break;

                        }

                        /*  //������
                          GameObject.Find(a).GetComponent<yr_ClickListener>().btn_Click();
                          //������
                          GameObject.Find(a).GetComponent<ClickListener>().btnClick();
                         */




                    }
                    catch (Exception ex)
                    {

                    }

                    //GameObject.Find(a).GetComponent<tt>().aa();

                    //GameObject.FindWithTag("tt").SendMessage("aa");


                }
            }
        }

    }
    private void PrintName(GameObject go)
    {
        //print("PrintName �޼���" + go.name);
    }
}
