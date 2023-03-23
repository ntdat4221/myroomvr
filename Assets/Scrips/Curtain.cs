using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curtain : MonoBehaviour
{
    public Animator curtain;
    public GameObject openText;
    public AudioSource curtainSound;


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

        if (inReach && Input.GetButtonDown("Curtain"))
        {
           CurtainCloses();
        }

        else
        {
           CurtainOpens();
        }




    }
    
    void CurtainCloses()
    {
        
        curtain.SetBool("Closed-curtain", true);
        curtain.SetBool("Open-curtain", false);
        curtainSound.Play();
    }
    void CurtainOpens()
    {

        curtain.SetBool("Closed-curtain", false);
        curtain.SetBool("Open-curtain", true);
       


    }

    


}
