using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanRotate : MonoBehaviour
{
    public GameObject openText;
    public bool inReach;
    float speed = 0.0f;
    private bool bRotate = false;

    public AudioSource fanSound;
   

    void Stop()
    {
        if (speed > 0.0f)
        {
            speed = speed - 1.0f;
            if (speed < 0.0f)
            {
                speed = 0.0f;
            }
        }
    }

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
            transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0));
            FanOpens();
            FanCloses();
        

    }

    void FanOpens()
    {
        

        if (Input.GetKey(KeyCode.Y))
        {
           fanSound.Play();
            bRotate = true;
            speed = speed + 2000.0f;
            if (speed > 2000.0f)
            {
                speed = 2000.0f;
            }
        }
       

        if (Input.GetKeyDown(KeyCode.U))
        {
            bRotate = true;
            speed = speed + 4000.0f;
            if (speed > 4000.0f)
            {
                speed = 4000.0f;
            }

        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            bRotate = true;
            speed = speed + 6000.0f;
            if (speed > 6000.0f)
            {
                speed = 6000.0f;
            }

        } 
        
    }

    void FanCloses()
    {
       
        if (bRotate == false)
        {
            Stop();
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            fanSound.Pause();
            bRotate = false;
        }
    }

}

