using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine.Networking;
using System;

public class bar_action : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Chart1_bar1;
    public GameObject Chart1_bar1_text;

    public GameObject Chart1_bar2;
    public GameObject Chart1_bar2_text;

    public GameObject Chart1_bar3;
    public GameObject Chart1_bar3_text;
    public GameObject Chart1_bar4;
    public GameObject Chart1_bar4_text;
    public GameObject Chart1_bar5;
    public GameObject Chart1_bar5_text;
    public GameObject Chart1_bar6;
    public GameObject Chart1_bar6_text;

    public GameObject final;

    public GameObject nation;
    public int RANK ;
    public int y = 30;

    private string json ="";


    //string nation_name = "가나";
    int[] array = new int[] { 10,45,15,15,0,10};

    string URL = "http://13.209.66.177/ENERGY/Energy_Statistic_Select.php";

    int use_energy = 0;
    void Start()
    {
        
        StartCoroutine(ToDB());

        //json 데이터 파싱해서 
        //array에 값 넣어주기
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void draw_graph()
    {

        // nation.GetComponent<TextMesh>().text = nation_name;
        Chart1_bar1_text.GetComponent<TextMesh>().text = array[0].ToString();
        Chart1_bar2_text.GetComponent<TextMesh>().text = array[1].ToString();
        Chart1_bar3_text.GetComponent<TextMesh>().text = array[2].ToString();
        Chart1_bar4_text.GetComponent<TextMesh>().text = array[3].ToString();
        Chart1_bar5_text.GetComponent<TextMesh>().text = array[4].ToString();
        Chart1_bar6_text.GetComponent<TextMesh>().text = array[5].ToString();

        final.GetComponent<TextMesh>().text = use_energy.ToString();
        //x축은 -30에서 70
        //x축은 0에서 100

        int x = 10 + (array[0] / 2);
        // int y = 30;
        float y_text = y + 8;
        int z = 0;
        print("x:" + x);

        Chart1_bar1.transform.localScale = new Vector3(array[0], 5, 1);
        Chart1_bar1.transform.localPosition = new Vector3(x, y, z);

        Chart1_bar1_text.transform.localPosition = new Vector3(x, y_text, z);
        if (array[0] == 0)
        {
            x = (x + (array[0] / 2)) + (array[1] / 2);
            Chart1_bar1_text.SetActive(false);
        }
        else
        {
            x = (x + (array[0] / 2)) + (array[1] / 2) + 1;
        }

        print("x:" + x);

        Chart1_bar2.transform.localScale = new Vector3(array[1], 5, 1);
        Chart1_bar2.transform.localPosition = new Vector3(x, y, z);
        Chart1_bar2_text.transform.localPosition = new Vector3(x, y_text, z);
        if (array[1] == 0)
        {
            Chart1_bar2_text.SetActive(false);
            x = (x + (array[1] / 2)) + (array[2] / 2);
        }
        else {
            x = (x + (array[1] / 2)) + (array[2] / 2) + 1;
        }

        print("x:" + x);

        Chart1_bar3.transform.localScale = new Vector3(array[2], 5, 1);
        Chart1_bar3.transform.localPosition = new Vector3(x, y, z);
        Chart1_bar3_text.transform.localPosition = new Vector3(x, y_text, z);
        if (array[2] == 0)
        {
            Chart1_bar3_text.SetActive(false);
            x = (x + (array[2] / 2)) + (array[3] / 2);
        }
        else
        {
            x = (x + (array[2] / 2)) + (array[3] / 2) + 1;
        }

        print("x:" + x);

        Chart1_bar4.transform.localScale = new Vector3(array[3], 5, 1);
        Chart1_bar4.transform.localPosition = new Vector3(x, y, z);
        Chart1_bar4_text.transform.localPosition = new Vector3(x, y_text, z);
        if (array[3] == 0)
        {
            Chart1_bar4_text.SetActive(false);
            x = (x + (array[3] / 2)) + (array[4] / 2);
        }
        else {
            x = (x + (array[3] / 2)) + (array[4] / 2) + 1;
        }
        
        print("x:" + x);

        Chart1_bar5.transform.localScale = new Vector3(array[4], 5, 1);
        Chart1_bar5.transform.localPosition = new Vector3(x, y, z);
        Chart1_bar5_text.transform.localPosition = new Vector3(x, y_text, z);

        if (array[4] == 0)
        {
            Chart1_bar5_text.SetActive(false);
            x = (x + (array[4] / 2)) + (array[5] / 2);
        }
        else
        {
            x = (x + (array[4] / 2)) + (array[5] / 2) + 1;
        }


        
        print("x:" + x);

        Chart1_bar6.transform.localScale = new Vector3(array[5], 5, 1);
        Chart1_bar6.transform.localPosition = new Vector3(x, y, z);
        Chart1_bar6_text.transform.localPosition = new Vector3(x, y_text, z);

        if (array[5] == 0)
        {
            Chart1_bar6_text.SetActive(false);
        }
    }
    IEnumerator ToDB()
    {


        WWWForm form = new WWWForm();
        form.AddField("Rank", RANK.ToString());

        WWW www = new WWW(URL, form);
        yield return www;

        json = www.text;


        JObject jObject = JObject.Parse(json);

        print(jObject.ToString());

        array[0] = Convert.ToInt32(jObject["ENERGY"][0]["coal"]) ;
        array[1] = Convert.ToInt32(jObject["ENERGY"][0]["oil"]);
        array[2] = Convert.ToInt32(jObject["ENERGY"][0]["naturalgas"]);
        array[3] = Convert.ToInt32(jObject["ENERGY"][0]["electricity"]);
        array[4] = Convert.ToInt32(jObject["ENERGY"][0]["heat"]);
        array[5] = Convert.ToInt32(jObject["ENERGY"][0]["other"]);
        use_energy = Convert.ToInt32(jObject["ENERGY"][0]["final"]);

        //  JToken jToken = jObject["ENERGY"]; ;

        //Debug.Log( "로그"+array[0].ToString());

        Debug.Log(www.text);

        print(www.text);
        draw_graph();


    }
}
