using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class Video : MonoBehaviour
{

    public VideoPlayer videos;
    // Start is called before the first frame update

    public void click_videobtn() { 
        //videos.
    }
   

    public void play_video()
    {
        videos.Play();
    }
    public void stop_video()
    {
        videos.Pause();
    }
}
