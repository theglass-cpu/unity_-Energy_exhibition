using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class close_Jump : MonoBehaviour
{
    public Transform other;
    public string name;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        room_jump();
    }
    public void room_jump()
    {



        float distance = Vector3.Distance(other.position, transform.position);

       

        if (name == "jy")
        {
            if (distance < 50f)
            {
                SceneManager.LoadScene("yr_scene");
                
            }
        }
        if (name == "yr")
        {
            if (distance < 50f)
            {
                SceneManager.LoadScene("sh_scene");

            }
        }
        if (name == "sh")
        {
            if (distance < 50f)
            {
                SceneManager.LoadScene("hy_scene2");

            }
        }

        if (name == "hj")
        {
            if (distance < 50f)
            {
                SceneManager.LoadScene("miniature_room");

            }
        }


    }
}
