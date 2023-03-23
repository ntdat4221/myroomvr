using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate50 : MonoBehaviour
{
    public Animator fan;
    public GameObject openText;


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

        if (inReach && Input.GetButtonDown("Fan"))
        {
            FanOpens();
        }

        else
        {
            FanCloses();
        }




    }
    void FanOpens()
    {
       
        fan.SetBool("Open", true);
        fan.SetBool("Closed", false);
       

    }

    void FanCloses()
    {
        
        fan.SetBool("Open", false);
        fan.SetBool("Closed", true);
    }
}