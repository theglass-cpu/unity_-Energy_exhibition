using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hj_PowerPlantClick : MonoBehaviour
{
    public GameObject PowerPlant;


    public void clickPowerPlantButton (string obj_name){
        Debug.Log(obj_name);
        switch (obj_name)
        {
            case "hj_renewable_btn":
                GameObject.Find("hj_KoreaGreenNewDealPlan").transform.Find("solar power plant").gameObject.SetActive(true);
                GameObject.Find("hj_KoreaGreenNewDealPlan").transform.Find("coal power plant").gameObject.SetActive(false);
                GameObject.Find("hj_KoreaGreenNewDealPlan").transform.Find("nuclear power plant").gameObject.SetActive(false);
                break;
            case "hj_coal_btn":
                GameObject.Find("hj_KoreaGreenNewDealPlan").transform.Find("coal power plant").gameObject.SetActive(true);
                GameObject.Find("hj_KoreaGreenNewDealPlan").transform.Find("solar power plant").gameObject.SetActive(false);
                GameObject.Find("hj_KoreaGreenNewDealPlan").transform.Find("nuclear power plant").gameObject.SetActive(false);
                break;
            case "hj_nuclear_btn":
                GameObject.Find("hj_KoreaGreenNewDealPlan").transform.Find("nuclear power plant").gameObject.SetActive(true);
                GameObject.Find("hj_KoreaGreenNewDealPlan").transform.Find("coal power plant").gameObject.SetActive(false);
                GameObject.Find("hj_KoreaGreenNewDealPlan").transform.Find("solar power plant").gameObject.SetActive(false);
                break;
        }
}
    public void InitPowerPlant()
    {
        GameObject.FindWithTag("coal").SetActive(false);
        GameObject.FindWithTag("nuclear").SetActive(false);
        GameObject.Find("hj_World'sGreenNewDeal").transform.Find("Eu").gameObject.SetActive(false);
    }

    public void ClickGreenNewDealBtn(string obj_name)
    {
        Debug.Log("!");
        switch (obj_name)
        {
            case "hj_america_btn":
                Debug.Log("1");
                GameObject.Find("hj_World'sGreenNewDeal").transform.Find("America").gameObject.SetActive(true);
                GameObject.Find("hj_World'sGreenNewDeal").transform.Find("Eu").gameObject.SetActive(false);
                break;
            case "hj_eu_btn":
                Debug.Log("2");
                GameObject.Find("hj_World'sGreenNewDeal").transform.Find("Eu").gameObject.SetActive(true);
                GameObject.Find("hj_World'sGreenNewDeal").transform.Find("America").gameObject.SetActive(false);
                break;

        }
    }

}
