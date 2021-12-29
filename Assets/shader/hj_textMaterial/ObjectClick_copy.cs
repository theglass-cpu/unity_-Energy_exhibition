using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClick_copy : MonoBehaviour
{

    // Start is called before the first frame update


    public Transform point;

    void Start()
    {
        GameObject.Find("hj_renewable_btn").GetComponent<hj_PowerPlantClick>().InitPowerPlant();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(point.position);
            if (Physics.Raycast(ray, out hit, 1000.0f))
            {
                if (hit.transform != null)
                {
                    string a = hit.transform.name;
                    try
                    {
                        if (a == "hj_renewable_btn" || a == "hj_coal_btn" || a == "hj_nuclear_btn")
                        {
                            GameObject.Find(a).GetComponent<hj_PowerPlantClick>().clickPowerPlantButton(a);
                        }else if (a== "hj_america_btn" || a == "hj_eu_btn")
                        {
                            GameObject.Find(a).GetComponent<hj_PowerPlantClick>().ClickGreenNewDealBtn(a);
                        }


                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }

    }
    private void PrintName(GameObject go)
    {
        print(go.name);
    }
}
