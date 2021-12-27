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
                PowerPlant = GameObject.Find("solar power plant");
                if (!PowerPlant.activeSelf)
                {
                    PowerPlant.SetActive(true);
                    if(GameObject.Find("coal power plant").activeSelf)
                    {
                        GameObject.Find("coal power plant").SetActive(false);
                    }
                    if (GameObject.Find("nuclear power plant").activeSelf)
                    {
                        GameObject.Find("nuclear power plant").SetActive(false);
                    }
                }
                break;
            case "coal_btn":
                PowerPlant = GameObject.Find("coal power plant");
                if (!PowerPlant.activeSelf)
                {
                    PowerPlant.SetActive(true);
                    if (GameObject.Find("solar power plant").activeSelf)
                    {
                        GameObject.Find("solar power plant").SetActive(false);
                    }
                    if (GameObject.Find("nuclear power plant").activeSelf)
                    {
                        GameObject.Find("nuclear power plant").SetActive(false);
                    }
                }
                break;
            case "nuclear_btn":
                PowerPlant = GameObject.Find("nuclear power plant");
                if (!PowerPlant.activeSelf)
                {
                    PowerPlant.SetActive(true);
                    if (GameObject.Find("coal power plant").activeSelf)
                    {
                        GameObject.Find("coal power plant").SetActive(false);
                    }
                    if (GameObject.Find("solar power plant").activeSelf)
                    {
                        GameObject.Find("solar power plant").SetActive(false);
                    }
                }
                break;
        }
}



}
