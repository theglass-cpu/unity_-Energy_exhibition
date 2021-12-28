using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yr_ClickListener : MonoBehaviour
{
    Renderer sr;

    // 클릭하고 싶은 오브젝트
    public GameObject clickObject;

    public GameObject yr_water_point, yr_gas_point, yr_bituminous_coal_point, yr_new_renewable_energy_point, yr_nuclear_power_point;


    private void Start()
    {
        yr_water_point.SetActive(false);
        yr_gas_point.SetActive(false);
        yr_bituminous_coal_point.SetActive(false);
        yr_new_renewable_energy_point.SetActive(false);
        yr_nuclear_power_point.SetActive(false);


    }

    public void btn_Click()
    {
        sr = clickObject.GetComponent<Renderer>();

        // 클릭하려는 오브젝트 이름
        string objectName = clickObject.name;
        print("정유리 코드들어옴" + objectName);

        switch (objectName) {
            case "yr_water_power_bt":
                Debug.Log("수력버튼클릭함");
                yr_water_point.SetActive(true);

                yr_gas_point.SetActive(false);
                yr_bituminous_coal_point.SetActive(false);
                yr_new_renewable_energy_point.SetActive(false);
                yr_nuclear_power_point.SetActive(false);


                break;
            case "yr_gas_bt":
                Debug.Log("가스버튼클릭함");
                yr_gas_point.SetActive(true);

                yr_water_point.SetActive(false);
                yr_bituminous_coal_point.SetActive(false);
                yr_new_renewable_energy_point.SetActive(false);
                yr_nuclear_power_point.SetActive(false);
                break;

            case "yr_nuclear_power_bt":
                Debug.Log("원자력버튼클릭함");

                yr_nuclear_power_point.SetActive(true);

                yr_water_point.SetActive(false);
                yr_gas_point.SetActive(false);
                yr_bituminous_coal_point.SetActive(false);
                yr_new_renewable_energy_point.SetActive(false);
                break;
            case "yr_new_renewable_energy_bt":
                Debug.Log("신재생버튼클릭함");

                yr_new_renewable_energy_point.SetActive(true);

                yr_nuclear_power_point.SetActive(false);
                yr_water_point.SetActive(false);
                yr_gas_point.SetActive(false);
                yr_bituminous_coal_point.SetActive(false);

                break;
            case "yr_bituminous_coal_bt":
                Debug.Log("유연탄버튼클릭함");
                yr_water_point.SetActive(false);
                yr_gas_point.SetActive(false);
                yr_bituminous_coal_point.SetActive(true);
                yr_new_renewable_energy_point.SetActive(false);
                yr_nuclear_power_point.SetActive(false);
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
            country.GetComponent<TextMesh>().text = "캐나다";
            content.GetComponent<TextMesh>().text = "- 1.17 ~ 18 : 동부 눈 폭, 적설량 최대 75cm, 최대풍속 150km/h";
        }
        else if (objectName.Equals("btn2"))
        {
            country.GetComponent<TextMesh>().text = "중미/대서양";
            content.GetComponent<TextMesh>().text = "- 11.3 ~ 6 : 최대풍속 225km/h, 허리케인 '에타', 홍수와 산사, 최소 130여명 사망\n";
        }
        else if (objectName.Equals("btn3"))
        {
            country.GetComponent<TextMesh>().text = "중미/대서양";
            content.GetComponent<TextMesh>().text = "- 11.3 ~ 6 : 최대풍속 225km/h, 허리케인 '에타', 홍수와 산사, 최소 130여명 사망\n";
        }*/
    }
}
