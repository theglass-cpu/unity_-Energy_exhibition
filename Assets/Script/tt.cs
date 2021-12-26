using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tt : MonoBehaviour
{
    Renderer sr;
    public GameObject go;
    //public Transform cube;

    // Start is called before the first frame update
    void Start()
    {
       // sr = go.GetComponent<SpriteRenderer>();
        //capsuleColor = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void aa ()
        {
        sr = go.GetComponent<Renderer>();
        sr.material.color = Color.green;
        }
}
