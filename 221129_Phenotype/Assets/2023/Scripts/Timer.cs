using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    
    public bool TimerOn = true;
    public Text[] ClickText;
    float time;
    public float scoreTime = 0.0f;
    
    
    
                  
    // Start is called before the first frame update
    public void Start()
    {
        TimerOn = false;
    }

    // Update is called once per frame
    void Update()
    {       
        if (TimerOn)
        {            
            time += Time.deltaTime;
            ClickText[0].text = ((int)time / 60 % 60).ToString("D2");
            ClickText[1].text = ((int)time % 60).ToString("D2");
            ClickText[2].text = ((float)time % 1).ToString("N1");







            scoreTime += Time.deltaTime;        
            if (scoreTime >= 600.0f)
            {
                SetTimerStop();
            }
        }
   }
    public void SetTimerOn()
    {
        TimerOn = true;       
    }
    public void SetTimerStop()
    {       
        TimerOn = false;
    }
}
