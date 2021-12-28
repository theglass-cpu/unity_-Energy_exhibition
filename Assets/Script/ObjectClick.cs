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
                    print("¹» ÃÆÁö ¸Þ¼­µå" + a);
                    Debug.Log("¹»Ä§?"+a);
                    string[] obj_name = a.Split('_');
                    try
                        {
                        switch (obj_name[0]) {
                            case "yr":
                                Debug.Log("Á¤À¯¸®ÃÆÀ½" );
                                GameObject.Find(a).GetComponent<yr_ClickListener>().btn_Click();
                                break;

                            case "sh":
                                Debug.Log("»óÈÆÃÆÀ½");
                                break;


                            case "hj":
                                Debug.Log("È£ÀçÃÆÀ½");
                                break;

                            case "jy":
                                Debug.Log("Áö¿¬ÃÆÀ½");
                                GameObject.Find(a).GetComponent<ClickListener>().btnClick();
                                break;

                        }

                        /*  //Á¤À¯¸®
                          GameObject.Find(a).GetComponent<yr_ClickListener>().btn_Click();
                          //ÀÌÁö¿¬
                          GameObject.Find(a).GetComponent<ClickListener>().btnClick();
                         */




                    }
                    catch (Exception ex)
                    {

                    }


                    //GameObject.Find(a).GetComponent<Jy_click>().btnClick();

                    //GameObject.Find(a).GetComponent<tt>().aa();

                    //GameObject.FindWithTag("tt").SendMessage("aa");


                }
            }
        }
     
    }
    private void PrintName(GameObject go)
    {
        print("PrintName ¸Þ¼­µå" + go.name);
    }
}
