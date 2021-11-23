using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timercounter : MonoBehaviour
{
    public static float countTval = 300;
    public Text countTimer;
    void Update()
    {
        if(countTval>0){
               countTval -= Time.deltaTime;   
        }else{
            countTval = 0; 
        }
        countdown(countTval);
    }
    public void countdown( float time){
        float min;
        float sec;
        if(time < 0){
            time = 0;
        }
        min = Mathf.FloorToInt(time / 60);//get the mintues
        sec = Mathf.FloorToInt(time % 60);//get the seconds
        countTimer.text = string.Format("{0:00}:{1:00}", min,sec);
    }
    
}
