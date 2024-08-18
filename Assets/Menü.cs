using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menü : MonoBehaviour
{
   public void PlayGame(){
        Debug.Log("Spiel Gestartet");
       SceneManager.LoadScene(1);
    }
}
