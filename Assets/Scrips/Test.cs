using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Animator pc;
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
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
        }
    }





    void Update()
    {

        if (inReach && Input.GetButtonDown("PC"))
        {
            PCOpens();
        }

        else
        {
            PCCloses();
        }




    }
    void PCOpens()
    {

        pc.SetBool("Open", true);
        pc.SetBool("Closed", false);
       

    }

    void PCCloses()
    {

        pc.SetBool("Open", false);
        pc.SetBool("Closed", true);
    }


}

