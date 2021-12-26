using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tt : MonoBehaviour
{
    Renderer sr;
    public GameObject go;
    //public Transform cube;

    // Start is called before the first frame update
    

    public void aa ()
        {
        sr = go.GetComponent<Renderer>();
        //if (objName == "water_power") { }
        sr.material.color = Color.green;


        }

}
