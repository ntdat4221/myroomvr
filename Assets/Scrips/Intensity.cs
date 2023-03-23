using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intensity : MonoBehaviour
{
    Light a;
    float i = 1.0f;
    float h = 0.12f;
    float s = 1f;
    float t = 0.002f;
    float j = 0.007f;
    Renderer m_Renderer;

    // Start is called before the first frame update
    void OnGUI()
    {
        GUI.Label(new Rect(5, 5, 300, 30), "Nhiệt độ màu ([ hoặc ]): " + s.ToString());
        GUI.Label(new Rect(5, 25, 300, 30), "Cường độ sáng (K hoặc L): " + i.ToString());
    }
    void Start()
    {
        a = GetComponent<Light>();
      
    }

    // Update is called once per frame
    void Update()
    {
        a.color = Color.HSVToRGB(h, s, i);
        
      
        if (Input.GetKey(KeyCode.RightBracket))
        {
           
            s = s + t;  
            if(s > 1) s = 1;

        }
        if (Input.GetKey(KeyCode.LeftBracket))
        {

            s = s - t;
            if (s < 0 ) s = 0;

        }
        if (Input.GetKey(KeyCode.L))
        {

            i = i + j;
            if (i > 2)
            {
                i = 2;
            }

        }
        if (Input.GetKey(KeyCode.K))
        {

            i = i - j;
            if (i < 0.5)
            {
                i = 0.5f;
            }

        }
        a.intensity = Mathf.PingPong(i, 2);
    }
}

