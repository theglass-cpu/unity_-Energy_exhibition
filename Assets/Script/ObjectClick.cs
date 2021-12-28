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
<<<<<<< HEAD

=======
                    print("�� ���� �޼���" + a);
                    Debug.Log("��ħ?"+a);
                    string[] obj_name = a.Split('_');
>>>>>>> a8c8100bd5fc825633d4170ac029cbb566493f5a
                    try
                        {
                        switch (obj_name[0]) {
                            case "yr":
                                Debug.Log("����������" );
                                GameObject.Find(a).GetComponent<yr_ClickListener>().btn_Click();
                                break;

                            case "sh":
                                Debug.Log("��������");
                                break;


                            case "hj":
                                Debug.Log("ȣ������");
                                break;

                            case "jy":
                                Debug.Log("��������");
                                GameObject.Find(a).GetComponent<ClickListener>().btnClick();
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
        print("PrintName �޼���" + go.name);
    }
}
