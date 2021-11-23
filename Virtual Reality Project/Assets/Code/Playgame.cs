using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Playgame : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider tp){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
