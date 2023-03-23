﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightDisplay : MonoBehaviour
{
    public GameObject onOB;
    public GameObject offOB;


    public GameObject lightOB;


    public bool lightsAreOn;
    public bool lightsAreOff;
    public bool inReach;


    void Start()
    {
        inReach = false;
        lightsAreOn = false;
        lightsAreOff = true;
        onOB.SetActive(false);
        offOB.SetActive(true);
        lightOB.SetActive(false);
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
        if(lightsAreOn && inReach && Input.GetButtonDown("Light"))
        {
            lightOB.SetActive(false);
            onOB.SetActive(false);
            offOB.SetActive(true);
            lightsAreOff = true;
            lightsAreOn = false;
        }

        else if (lightsAreOff && inReach && Input.GetButtonDown("Light"))
        {
            lightOB.SetActive(true);
            onOB.SetActive(true);
            offOB.SetActive(false);
            lightsAreOff = false;
            lightsAreOn = true;
        }


    }
}
