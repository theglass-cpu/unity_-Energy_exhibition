using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getHJD : MonoBehaviour
{
    void Start()
    {
        GameObject game;

        int count = transform.childCount;
        for (int i = 0; i < count; i++)
        {
            string adress = transform.GetChild(i).name;
            game = GameObject.Find(adress);
            getUseQty(adress);
        }
    }

    void setColor(GameObject gameobj, float useQty)
    {

    }

    void getUseQty(string adress)
    {
        string[] adresscode = adress.Split(new char[] { ' ' });
        string bjd = adresscode[2];
        Debug.Log(bjd);
    }

    public int getbjdCode(string bjd)
    {
        switch (bjd)
        {
            case "������1��":
                return 10400;
            case "������2��":
                return 10500;
            case "���ϵ�":
                return 10800;
            case "�ٵ�":
                return 10200;
            case "����1��":
                return 13100;
            case "����2��":
                return 16100;
            case "��1��":
                return 12600;
            case "���빮��2��":
                return 11500;
            case "�Ұ���":
                return 11100;
            case "��ǥ��":
                return 11000;
            case "�屳��":
                return 10900;
            default: return 0;
        }
    }

}
