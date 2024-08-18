using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fight : MonoBehaviour
{
    public bool gegnerkontakt;
    private Collider2D gegner;

    void Update()
    {
        if(gegnerkontakt == true && Input.GetKey("Mouse clicked")){
            Destroy(gegner.gameObject);
        }
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
}
