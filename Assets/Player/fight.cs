using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fight : MonoBehaviour
{
    public bool gegnerkontakt;

    public Teleporter teleporter;
    private Collider2D gegner;

    void Update()
    {
        if(gegnerkontakt == true && Input.GetMouseButton(0)){
            Destroy(gegner.gameObject);
            teleporter.SetzeGegner();
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
