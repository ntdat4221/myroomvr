using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVid : MonoBehaviour
{
    public VideoPlayer video;
    public bool inReach;
    bool on = false;
    private void Awake()
    {
        video = GetComponent<VideoPlayer>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
           
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
           
        }
    }


    private void Update()
    {
        PlayVideo();
    }
    public void PlayVideo()
    {
               if (inReach && Input.GetMouseButtonDown(0))
               {
                     on = !on;
                     video.Pause(); 
            
                   if (on)
                   {
                        video.Play();
                   }
               }
       
               if (inReach && Input.GetMouseButtonDown(1))
               {
                    video.Stop();
               }

        }
    }
        


