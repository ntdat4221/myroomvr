using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpeakerSound : MonoBehaviour
{

    public GameObject openText;
    public AudioSource speakerSound;
    public bool inReach;
    

    void Start()
    {
        inReach = false;

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            openText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            openText.SetActive(false);
        }
    }


    void Update()
    {

        if (inReach && Input.GetButtonDown("Sound"))
        {
           speakerSound.Play();
        }
        else if (Input.GetButtonDown("Sound1"))
        {
            speakerSound.Pause();
        }
     
    }
}
   
