using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_dash : MonoBehaviour
{
    public float Geschwindichkeit;
    private float dashkuldown;
    public float dashtime;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w")){
            transform.Translate(Vector2.up*Geschwindichkeit*Time.deltaTime,Space.World);
            if(Input.GetKey("space") && dashkuldown > dashtime){
                transform.Translate(Vector2.up*Geschwindichkeit*Time.deltaTime*10,Space.World);
                dashkuldown = 0;
            }
        }
        if(Input.GetKey("s")){
            transform.Translate(Vector2.down*Geschwindichkeit*Time.deltaTime,Space.World);
            if(Input.GetKey("space") &&dashkuldown > dashtime){
                transform.Translate(Vector2.down*Geschwindichkeit*Time.deltaTime*10,Space.World);
                dashkuldown = 0;
            }
        }
        if(Input.GetKey("d")){
            transform.Translate(Vector2.right*Geschwindichkeit*Time.deltaTime,Space.World);
            if(Input.GetKey("space") && dashkuldown > dashtime){
                transform.Translate(Vector2.right*Geschwindichkeit*Time.deltaTime*10,Space.World);
                dashkuldown = 0;
            }
        }
        if(Input.GetKey("a")){
            transform.Translate(Vector2.left*Geschwindichkeit*Time.deltaTime,Space.World);
            if(Input.GetKey("space") && dashkuldown > dashtime){
                transform.Translate(Vector2.left*Geschwindichkeit*Time.deltaTime*10,Space.World);
                dashkuldown = 0;
            }
        }

        dashkuldown = dashkuldown + Time.deltaTime;
    }
}
