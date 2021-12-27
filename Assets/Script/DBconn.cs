using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class DBconn : MonoBehaviour
{

    string LoginURL = "http://13.209.66.177/ENERGY/Select.php";

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
        print("db시작");

        Debug.Log("db시작");

        WWWForm form = new WWWForm();
        form.AddField("query", query);

        WWW www = new WWW(LoginURL, form);
        yield return www;

        Debug.Log(www.text);
        print(www.text);

        /*using (UnityWebRequest www = UnityWebRequest.Post(LoginURL, form))
        {
            yield return www.SendWebRequest();

            
            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);

            }
            else {
                Debug.Log(www.downloadHandler.text);
            }

    }*/

        Debug.Log("끝");
        print("끝");


    }
}
