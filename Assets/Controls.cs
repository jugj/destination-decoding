using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controls : MonoBehaviour
{
   public void PlayGame1(){
        Debug.Log("Spiel Gestartet");
       SceneManager.LoadScene(2);
    }
}
