using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fight : MonoBehaviour
{
    public bool gegnerkontakt;

    public GameObject gameObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gegnerkontakt == true && Input.GetKey("space")){
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "Gegner"){
            gegnerkontakt = true;           
        }
    }
    void OnCollisionExit2D(Collision2D collision){
        if (collision.gameObject.tag == "Gegner"){
            gegnerkontakt = false;           
        }
    }
}
