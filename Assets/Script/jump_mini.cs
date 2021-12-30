using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump_mini : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.X))
        {
            GameObject.Find("Main Camera").GetComponent<Scene_Jumping>().Jump();

        }
    }
}
