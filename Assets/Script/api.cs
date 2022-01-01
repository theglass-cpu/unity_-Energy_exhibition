using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.Xml;
public class api : MonoBehaviour
{
    string xmlResult;
    bool isOnLoading = true;

    void Start()
    {
        StartCoroutine(LoadData());
    }


    IEnumerator LoadData() //json 문자열 받아오기
    {
        string GetDataUrl = "http://apis.data.go.kr/1611000/BldEngyService/getBeElctyUsgInfo?serviceKey=DWbrLR2ujfse1XuO8PAws4RslOtGNQJm4GfVplJ07iblYuUmK%2BnIy9SneMX5acXUUZrzsNkfI1dOX1daJNyBbQ%3D%3D&numOfRows=1&pageNo=1&sigunguCd=11680&bjdongCd=10300&bun=0012&ji=0000&useYm=202109";
        using (UnityWebRequest www = UnityWebRequest.Get(GetDataUrl))
        {
            //www.chunkedTransfer = false;
            yield return www.Send();
            if (www.isNetworkError || www.isHttpError) //불러오기 실패 시
            {
                Debug.Log(www.error);
            }
            else
            {
                if (www.isDone)
                {
                    isOnLoading = false;
                    xmlResult = System.Text.Encoding.UTF8.GetString(www.downloadHandler.data);
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.Load(xmlResult);

                    XmlNode useQty_node = xmlDocument.SelectSingleNode("response/body/items/item/useQty");
                    string userQty = useQty_node.InnerText;

                    Debug.Log(userQty);

                }
            }
        }
    }

}
