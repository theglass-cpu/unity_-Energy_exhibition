using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClick : MonoBehaviour
{
    // Start is called before the first frame update


    public Transform point;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(point.position);

            if (Physics.Raycast(ray, out hit, 1000.0f))
            {
                if (hit.transform != null)
                {
                    PrintName(hit.transform.gameObject);
                    string a = hit.transform.name;
                    GameObject.Find(a).GetComponent<tt>().aa();
                    //GameObject.FindWithTag("tt").SendMessage("aa");
                   

                }
            }
        }
     
    }
    private void PrintName(GameObject go)
    {
        print(go.name);
    }
}
