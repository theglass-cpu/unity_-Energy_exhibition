using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Jumping : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void Jump() {
        SceneManager.LoadScene("Miniature_scene");

    }
    public void Jump_ex()
    {
        SceneManager.LoadScene("miniature_room");

    }
}
