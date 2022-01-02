using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.Xml;
using System.Text.RegularExpressions;

public class call_child : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject game;

        int count = transform.childCount;
        for (int i = 0; i < 19; i++)
        {

            string adress = transform.GetChild(i).name;
            game = GameObject.Find(adress);

            //�̸��� ���� ���»�뷮 �޾ƿ�
            Debug.Log("�ּ� :"+adress+"  ���� ��뷮 :"+getUseQty(adress));

            //���»�뷮 ���ؿ� ���� �� ������
            setColor(game, 10f);
        }
    }

    void setColor(GameObject gameobj, float useQty)
    {

    }

    string getUseQty(string adress)
    {
        string[] adresscode = adress.Split(new char[] { ' ' });
        string bjd = adresscode[2];
        string bunji = adresscode[3];
        string[] bunjicode = bunji.Split(new char[] { '-' });
        string bun = bunjicode[0];
        string ji;

        if (bunjicode.Length == 2)
        {
            ji = bunjicode[1];
        }
        else {
            ji = "";
        }

        string GetDataUrl;

        GetDataUrl = "http://apis.data.go.kr/1611000/BldEngyService/getBeElctyUsgInfo?serviceKey=DWbrLR2ujfse1XuO8PAws4RslOtGNQJm4GfVplJ07iblYuUmK%2BnIy9SneMX5acXUUZrzsNkfI1dOX1daJNyBbQ%3D%3D&numOfRows=1&pageNo=1&sigunguCd=11140&" +
       "bjdongCd=" + getbjdCode(bjd) + "&bun=" + initBun(bun) + "&ji=" + initJi(ji) + "&useYm=202109";
        Debug.Log(GetDataUrl);
        XmlDocument xml = new XmlDocument();
        xml.Load(GetDataUrl);
        XmlNodeList xnList = xml.GetElementsByTagName("item"); //������ ���
        foreach (XmlNode xn in xnList)
        {
            string useQty = xn["useQty"].InnerText;
            return useQty;
        }
        return null;

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
            default: return 0;
        }
    }

    public string initBun(string bun)
    {
        switch (bun.Length)
        {
            case 1:
                return "000" + bun;
            case 2:
                return "00" + bun;
            case 3:
                return "0" + bun;
            default: return "0000";
        }
    }

    public string initJi(string ji)
    {
        switch (ji.Length)
        {
            case 1:
                return "000" + ji;
            case 2:
                return "00" + ji;
            case 3:
                return "0" + ji;
            default: return "0000";
        }
    }
}
