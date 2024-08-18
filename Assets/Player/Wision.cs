using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wision : MonoBehaviour
{
    public bool wisiontoplayer;
    public	GameObject player;
    public	GameObject gegner;



    void Update()
    {

        if(wisiontoplayer == true){
            gegner.transform.position = Vector3.MoveTowards(gegner.transform.position, player.transform.position, 1*Time.deltaTime);
        }
    }
    void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.tag == "player"){
            wisiontoplayer = true;        
        }
    }
    void OnTriggerExit2D(Collider2D other){
        if (other.gameObject.tag == "player"){
            wisiontoplayer = false;           
        }
    }
}
