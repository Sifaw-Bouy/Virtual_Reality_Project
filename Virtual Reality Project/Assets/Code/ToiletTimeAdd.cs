using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToiletTimeAdd : MonoBehaviour
{
    public void OnTriggerEnter(Collider tp){
        Timercounter.countTval +=60;
        Destroy(gameObject);
    }
}
