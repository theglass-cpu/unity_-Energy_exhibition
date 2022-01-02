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
            case "을지로1가":
                return 10400;
            case "을지로2가":
                return 10500;
            case "수하동":
                return 10800;
            case "다동":
                return 10200;
            case "저동1가":
                return 13100;
            case "저동2가":
                return 16100;
            case "명동1가":
                return 12600;
            case "남대문로2가":
                return 11500;
            case "소공동":
                return 11100;
            case "수표동":
                return 11000;
            case "장교동":
                return 10900;
            default: return 0;
        }
    }

}
