using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public int gegnerzahl = 2;

    public int[] gegnerprolevel = new int[] {5,10,5};

    public int level = 0;
    public GameObject player;

    public void GegnerZähler (int gegnerzahl){
        if (gegnerzahl == 0){
            if (level == 0){
                player.transform.position = new Vector3(67.5f,-13.5f,-3f);
                level += 1;}

            if (level == 1){
                player.transform.position = new Vector3(67.5f,-13.5f,-3f);
                level += 1;}

            if (level == 2){
                }
        }
    }
    public void SetzeGegner(){
        gegnerzahl -= 1;
    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log(level);
        GegnerZähler(gegnerprolevel[level]);
    }
}
