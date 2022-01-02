using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.Xml;
using System.Text.RegularExpressions;

public class call_child : MonoBehaviour
{
    // Start is called before the first frame update

    Material mat;

    float allQty =0f;//전력사용량 전체합
    float averageQty =0f;//평균 전력사용량
    float topQty = 0f;// 최대 건물전력사용량
    float UseQty_f =0f; //건물전력사용량 float형

    float div =0f;//건물 최대 전력사용량 8나눈값
    void Start()
    {
        mat = GetComponent<Material>();
        GameObject game;
        for (int i = 0; i < 19; i++)
        {

            //평균값 구하기 반복문
            string adress = transform.GetChild(i).name;

            string UseQty = getUseQty(adress);

            UseQty_f = float.Parse(UseQty);

            if (topQty < UseQty_f) {
                topQty = UseQty_f;
            }

            allQty = allQty + UseQty_f;

            averageQty = allQty / 19;


        }
        float div = topQty / 8;
        
        

        int count = transform.childCount;
        for (int i = 0; i < 19; i++)
        {

            string adress = transform.GetChild(i).name;
            game = GameObject.Find(adress);
            string UseQty = getUseQty(adress);
            UseQty_f = float.Parse(UseQty);//string 을 float 으로 변환
            //이름에 따라 전력사용량 받아옴
            Debug.Log("주소 :"+adress+"  전기 사용량 :"+ UseQty);



            setColor(game, UseQty_f);


        }
      
        //전력사용량 기준에 따라 색 입히기
    }

    void setColor(GameObject gameobj, float useQty)
    {

        if (div == null)
        {
            return;
        }
        //averageQty 평균 전력사용량
        //useQty 건물 전력사용량
        //Material material =Materi ;
        gameobj.GetComponent<Renderer>().material.color = Color.green;

        if (useQty > div * 7)
        {

        }else
        if (useQty > div * 6)
        {

        }else
        if (useQty > div * 5)
        {

        }else
        if (useQty > div * 4)
        {

        }else
        if (useQty > div * 3)
        {

        }else
        if (useQty > div * 2)
        {

        }else
        if (useQty > div)
        {

        }
       
       
    
   
        
      
       
      
    
   
    
        
        

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
        XmlNodeList xnList = xml.GetElementsByTagName("item"); //접근할 노드
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
            case "을지로1가":
                return 10400;
            case "을지로2가":
                return 10500;
            case "수하동":
                return 10800;
            case "다동":
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
