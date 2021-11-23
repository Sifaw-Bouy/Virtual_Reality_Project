using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ToiletScore : MonoBehaviour
{
    public GameObject tpScore;
    public static int tScore;
    int index= 0;
    public void Start(){
        index = Random.Range(0,5);   
    }
    public void Update(){
        // update timer here also
        tpScore.GetComponent<Text>().text = "TP Found: "+ tScore +"/10";
        if(tScore >= 10){
            string[] statements = {"All TP Found!, No more brown underwear!",
                                    "All TP Found!, TP coin is going to be huge", 
                                    "All TP Found!, Mate you could just invest in bidet!", 
                                    "All TP Found!, YES! they are all mine!"};                       
            tpScore.GetComponent<Text>().text = statements[index];
        }
    }
}
