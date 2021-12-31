using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yr_ClickListener : MonoBehaviour
{
    Renderer sr;

    // Ŭ���ϰ� ���� ������Ʈ
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

        // Ŭ���Ϸ��� ������Ʈ �̸�
        string objectName = clickObject.name;
        print("������ �ڵ���� �̰Ŵ��� =>" + objectName);

        switch (objectName) {
            case "yr_water_power_bt":
                Debug.Log("���¹�ưŬ����");
                yr_water_point.SetActive(true);

                yr_gas_point.SetActive(false);
                yr_bituminous_coal_point.SetActive(false);
                yr_new_renewable_energy_point.SetActive(false);
                yr_nuclear_power_point.SetActive(false);


                break;
            case "yr_gas_bt":
                Debug.Log("������ưŬ����");
                yr_gas_point.SetActive(true);

                yr_water_point.SetActive(false);
                yr_bituminous_coal_point.SetActive(false);
                yr_new_renewable_energy_point.SetActive(false);
                yr_nuclear_power_point.SetActive(false);
                break;

            case "yr_nuclear_power_bt":
                Debug.Log("���ڷ¹�ưŬ����");

                yr_nuclear_power_point.SetActive(true);

                yr_water_point.SetActive(false);
                yr_gas_point.SetActive(false);
                yr_bituminous_coal_point.SetActive(false);
                yr_new_renewable_energy_point.SetActive(false);
                break;
            case "yr_new_renewable_energy_bt":
                Debug.Log("�������ưŬ����");

                yr_new_renewable_energy_point.SetActive(true);

                yr_nuclear_power_point.SetActive(false);
                yr_water_point.SetActive(false);
                yr_gas_point.SetActive(false);
                yr_bituminous_coal_point.SetActive(false);

                break;
            case "yr_bituminous_coal_bt":
                Debug.Log("����ź��ưŬ����");
                yr_water_point.SetActive(false);
                yr_gas_point.SetActive(false);
                yr_bituminous_coal_point.SetActive(true);
                yr_new_renewable_energy_point.SetActive(false);
                yr_nuclear_power_point.SetActive(false);
                break;

            case "yr_move_secn_bt":

                Debug.Log("���̵�ť�� Ŭ����");
                Changemap();

                break;


        }
        


   
    }


    public void Changemap() {

        Debug.Log("�ڵ�����");
        SceneManager.LoadScene("yr_move_scenes");
    }

}
