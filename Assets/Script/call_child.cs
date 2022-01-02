using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.Xml;
using System.Text.RegularExpressions;

public class call_child : MonoBehaviour
{
    // Start is called before the first frame update


    float allQty =0f;//전력사용량 전체합
    float averageQty =0f;//평균 전력사용량
    float topQty = 0f;// 최대 건물전력사용량
    float UseQty_f =0f; //건물전력사용량 float형

    float div =200000f;//건물 최대 전력사용량 8나눈값
    public Material mat7;
    public Material mat6;
    public Material mat5;
    public Material mat4;
    public Material mat3;
    public Material mat2;
    public Material mat1;


    void Start()
    {

        int count = transform.childCount;

        //mat = GetComponent<Material>();
        GameObject game;
        for (int i = 0; i < count; i++)
        {

            //평균값 구하기 반복문
            string adress = transform.GetChild(i).name;

            string UseQty = getUseQty(adress);

            if (UseQty != null && UseQty != "")
            {
                UseQty_f = float.Parse(UseQty);
            }

            

            if (topQty < UseQty_f) {
                topQty = UseQty_f;
            }

            allQty = allQty + UseQty_f;

            averageQty = allQty / 19;


        }
       // div = topQty / 8;
        
        

        for (int i = 0; i < count; i++)
        {

            string adress = transform.GetChild(i).name;
            game = GameObject.Find(adress);
            string UseQty = getUseQty(adress);
            if (UseQty != null && UseQty != "")
            {
                UseQty_f = float.Parse(UseQty);//string 을 float 으로 변환
            }

            //이름에 따라 전력사용량 받아옴
            Debug.Log("주소 :"+adress+"  전기 사용량 :"+ UseQty);



            setColor(game, UseQty_f);


        }
      
        //전력사용량 기준에 따라 색 입히기
    }

    void setColor(GameObject gameobj, float useQty)
    {

        if (div== null)
        {
            return;
        }
        //averageQty 평균 전력사용량
        //useQty 건물 전력사용량
        //Material material =Materi ;
       // Material material = MaterialPropertyBlock.ReferenceEquals(, gameobj.GetComponent<Material>());


        if (useQty > div * 7)
        {
            gameobj.GetComponent<Renderer>().material = mat7;

        }else
        
        if(  useQty > div * 6)
        {
            gameobj.GetComponent<Renderer>().material = mat6;

        }
        else
        if (useQty > div * 5)
        {
            gameobj.GetComponent<Renderer>().material = mat5;

        }
        else
        if (useQty > div * 4)
        {
            gameobj.GetComponent<Renderer>().material = mat4;

        }
        else
        if (useQty > div * 3)
        {
            gameobj.GetComponent<Renderer>().material = mat3;

        }
        else
        if (useQty > div * 2)
        {
            gameobj.GetComponent<Renderer>().material = mat2;

        }
        else
        if (useQty > div)
        {
            gameobj.GetComponent<Renderer>().material = mat1;

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
