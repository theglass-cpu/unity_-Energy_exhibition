using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jy_click : MonoBehaviour
{
    Renderer sr;
    public GameObject go;
    //public Transform cube;

    // Start is called before the first frame update


    public void btnClick()
    {
        sr = go.GetComponent<Renderer>();
        
        if (sr.material.color == Color.green)
        {
            sr.material.color = Color.yellow;
        }
        else
        {
            sr.material.color = Color.green;
        }
    }
}
