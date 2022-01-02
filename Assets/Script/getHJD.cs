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
}
