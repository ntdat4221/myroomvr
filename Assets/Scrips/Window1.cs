using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window1 : MonoBehaviour
{
    public Animator door;
    public GameObject openText;
    public AudioSource wardrobeSound;

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

        if (inReach && Input.GetButtonDown("Window"))
        {
            WindowOpens();
        }

        else
        {
            WindowCloses();
        }




    }
    void WindowOpens()
    {
        door.SetBool("Open-window", true);
        door.SetBool("Closed-window", false);
        wardrobeSound.Play();
    }

    void WindowCloses()
    {
        door.SetBool("Open-window", false);
        door.SetBool("Closed-window", true);
    }


}
