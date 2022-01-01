using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.Xml;
using System.Text.RegularExpressions;

public class api : MonoBehaviour
{
    string xmlResult;
    bool isOnLoading = true;

    void Start()
    {
        LoadData();
    }


    void LoadData() //json 문자열 받아오기
    {
        string GetDataUrl = "http://apis.data.go.kr/1611000/BldEngyService/getBeElctyUsgInfo?serviceKey=DWbrLR2ujfse1XuO8PAws4RslOtGNQJm4GfVplJ07iblYuUmK%2BnIy9SneMX5acXUUZrzsNkfI1dOX1daJNyBbQ%3D%3D&numOfRows=1&pageNo=1&sigunguCd=11680&bjdongCd=10300&bun=0012&ji=0000&useYm=202109";
        XmlDocument xml = new XmlDocument();
        xml.Load(GetDataUrl);
        XmlNodeList xnList = xml.GetElementsByTagName("item"); //접근할 노드

        foreach (XmlNode xn in xnList)
        {
            string useQty = xn["useQty"].InnerText;
            Debug.Log(useQty);
        }

    }

}
