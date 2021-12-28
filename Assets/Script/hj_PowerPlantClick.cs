using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hj_PowerPlantClick : MonoBehaviour
{
    public GameObject PowerPlant;


    public void clickButton (string obj_name){
        switch (obj_name)
        {
            case "renewable_btn":
                GameObject.Find("hj_KoreaGreenNewDealPlan").transform.Find("solar power plant").gameObject.SetActive(true);
                GameObject.Find("hj_KoreaGreenNewDealPlan").transform.Find("coal power plant").gameObject.SetActive(false);
                GameObject.Find("hj_KoreaGreenNewDealPlan").transform.Find("nuclear power plant").gameObject.SetActive(false);
                break;
            case "coal_btn":
                GameObject.Find("hj_KoreaGreenNewDealPlan").transform.Find("coal power plant").gameObject.SetActive(true);
                GameObject.Find("hj_KoreaGreenNewDealPlan").transform.Find("solar power plant").gameObject.SetActive(false);
                GameObject.Find("hj_KoreaGreenNewDealPlan").transform.Find("nuclear power plant").gameObject.SetActive(false);
                break;
            case "nuclear_btn":
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
    }



}
