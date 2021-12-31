using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        print("정유리 코드들어옴 이거누름 =>" + objectName);

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

            case "yr_move_secn_bt":

                Debug.Log("씬이동큐브 클릭함");
                Changemap();

                break;


        }
        


   
    }


    public void Changemap() {

        Debug.Log("코드탔음");
        SceneManager.LoadScene("yr_move_scenes");
    }

}
