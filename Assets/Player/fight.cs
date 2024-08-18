using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fight : MonoBehaviour
{
    public bool gegnerkontakt;

    public Teleporter teleporter;
    private Collider2D gegner;

    private bool rechts = true;

    private Animator anim;

    public GameObject gameObject;

    void Start(){
        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            if(rechts){
                anim.SetTrigger("attack_right");
            }else{
                    anim.SetTrigger("attack_left");
            }
            if(gegnerkontakt == true){
                Destroy(gegner.gameObject);
                teleporter.SetzeGegner();
            }
            
        }

        
        GetDirection();
    }
    void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.tag == "Gegner"){
            gegnerkontakt = true;  
            gegner = other;         
        }
    }
    void OnTriggerExit2D(Collider2D other){
        if (other.gameObject.tag == "Gegner"){
            gegnerkontakt = false;           
        }
    }

    void GetDirection(){
        if(Input.GetKeyDown("d")){
            rechts = true;
        }
        if(Input.GetKeyDown("a")){
            rechts = false;
        }
    }
}
