using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ToiletCollecter : MonoBehaviour
{

    public void OnTriggerEnter(Collider tp){
        ToiletScore.tScore +=1;
        Destroy(gameObject);
    }
}
