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
    private float time;
    public float enemyhit;
    public int playerlive;
    public int Maximalleben =5;
    public Healthbar healthbar;

    void Start(){
        anim = gameObject.GetComponent<Animator>();
        playerlive = Maximalleben;
        healthbar.SetzeMaxLeben(Maximalleben);
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
        if(gegnerkontakt == true){
            if(time > enemyhit){
                playerlive -= 1;
                healthbar.SetzeLeben(playerlive);
                Debug.Log("Schaden");
                time = 0;
            }
            else{
                time = time + Time.deltaTime;
            }
            if(playerlive == 0){
                Destroy(gameObject);
                
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
