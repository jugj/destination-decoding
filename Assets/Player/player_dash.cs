using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class player_dash : MonoBehaviour
{
    public float Geschwindichkeit;
    private float dashkuldown;
    public float dashtime;
    private float i;
    public float dashdistance;
    public float m_Thrust = 20f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();


        if(Input.GetKey("w")){                                                              //normales Moven
            rb.AddForce(Vector2.up, ForceMode2D.Impulse);
            if(Input.GetKey("space") && dashkuldown > dashtime){                            //Dash
                rb.AddForce(Vector2.up*20, ForceMode2D.Impulse);                      
                dashkuldown = 0;
            }
        }
        if(Input.GetKey("s")){
            rb.AddForce(Vector2.down, ForceMode2D.Impulse);
            if(Input.GetKey("space") && dashkuldown > dashtime){
                rb.AddForce(Vector2.down*20, ForceMode2D.Impulse);    
                dashkuldown = 0;
            }
        }
        if(Input.GetKey("d")){
            rb.AddForce(Vector2.right, ForceMode2D.Impulse);
            if(Input.GetKey("space") && dashkuldown > dashtime){
                rb.AddForce(Vector2.right*20, ForceMode2D.Impulse);                   
                dashkuldown = 0;
            }
        }
        if(Input.GetKey("a")){
            rb.AddForce(Vector2.left, ForceMode2D.Impulse);
            if(Input.GetKey("space") && dashkuldown > dashtime){
                rb.AddForce(Vector2.left*20, ForceMode2D.Impulse);
                dashkuldown = 0;
            }
        }

        dashkuldown = dashkuldown + Time.deltaTime;
    }
}
