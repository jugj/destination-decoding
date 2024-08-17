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
    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();


        if(Input.GetKey("w")){
            transform.Translate(Vector2.up*Geschwindichkeit*Time.deltaTime,Space.World);
            if(Input.GetKey("space") && dashkuldown > dashtime){
                rb.AddForce(transform.up * m_Thrust);                                  
                dashkuldown = 0;
            }
        }
        if(Input.GetKey("s")){
            transform.Translate(Vector2.down*Geschwindichkeit*Time.deltaTime,Space.World);
            if(Input.GetKey("space") && dashkuldown > dashtime){
                rb.AddForce(transform.up * m_Thrust);    
                dashkuldown = 0;
            }
        }
        if(Input.GetKey("d")){
            transform.Translate(Vector2.right*Geschwindichkeit*Time.deltaTime,Space.World);
            if(Input.GetKey("space") && dashkuldown > dashtime){
                rb.AddForce(transform.up * m_Thrust);                   
                dashkuldown = 0;
            }
        }
        if(Input.GetKey("a")){
            transform.Translate(Vector2.left*Geschwindichkeit*Time.deltaTime,Space.World);
            if(Input.GetKey("space") && dashkuldown > dashtime){
                rb.AddForce(transform.up * m_Thrust);
                dashkuldown = 0;
            }
        }

        dashkuldown = dashkuldown + Time.deltaTime;
    }
}
