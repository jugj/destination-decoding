using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour
{

    public int[] gegnerprolevel = new int[] {5,10,5};

    public int level = 0;
    public GameObject player;

    public int gegnerzahl = 0;
    public bool destroy;
    public bool destroy2;

    public GameObject Level2;
    public GameObject Level3;


    public void GegnerZähler (int gegnerzahl){
        if (gegnerzahl == 0){
            if (level == 0){
                player.transform.position = new Vector3(67.5f,-13.5f,-3f);
                level += 1;
                Level2.SetActive(true);
                destroy = true;
                }

            else if (level == 1){
                player.transform.position = new Vector3(67.5f,-13.5f,-3f);
                level += 1;
                Level3.SetActive(true);
                destroy2 = true;
                
                }

            else if (level == 2){
               SceneManager.LoadScene(4); }
        }
    }
    public void SetzeGegner(){
        gegnerprolevel[level] -= 1;
    }


    void Start (){
        gegnerzahl = gegnerprolevel[level];
        Level2.SetActive(false);
        Level3.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(level);
        GegnerZähler(gegnerprolevel[level]);
    }
}
