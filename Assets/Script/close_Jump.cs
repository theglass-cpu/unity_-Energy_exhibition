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

        if (name == "hj")
        {
            if (distance < 50f)
            {
                SceneManager.LoadScene("hy_scene2");

            }
        }

<<<<<<< HEAD
        if (name == "jy")
        {
            if (distance < 50f)
            {
                SceneManager.LoadScene("jy_scene");

            }
        }



=======
        //print("다른 사람과의 거리: " + distance);
>>>>>>> ce271b7e3280f676bedbf6a36afbe71bc123235e

    }
}
