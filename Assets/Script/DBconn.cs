using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class DBconn : MonoBehaviour
{

    string LoginURL = "http://15.164.50.211/ENERGY/Select.php";

    // Start is called before the first frame update
    void Start()
    {
        //LoginToDB("123");

        StartCoroutine(LoginToDB(""));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    IEnumerator LoginToDB( string query)
    {
      

        WWWForm form = new WWWForm();
        form.AddField("query", query);

        WWW www = new WWW(LoginURL, form);
        yield return www;

        Debug.Log(www.text);
        print(www.text);



    }
}
