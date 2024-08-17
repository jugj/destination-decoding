using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class player_dash : MonoBehaviour
{
    public float Geschwindichkeit;
    private float dashkuldown;
    public float dashtime;
    private Rigidbody2D rb;
    private Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey("w")){                                                              //normales Moven
            Dash(Vector2.up, "dash_right");
        }
        if(Input.GetKey("s")){
            Dash(Vector2.down, "dash_left");
        }
        if(Input.GetKey("d")){
            Dash(Vector2.right, "dash_right");
        }
        if(Input.GetKey("a")){
            Dash(Vector2.left, "dash_left");
        }

        dashkuldown = dashkuldown + Time.deltaTime;
    }

    private void Dash(Vector2 vector, string animation){
        rb.AddForce(vector * Geschwindichkeit, ForceMode2D.Impulse);
            if(Input.GetKey("space") && dashkuldown > dashtime){
                rb.AddForce(vector * 20 * Geschwindichkeit, ForceMode2D.Impulse);
                dashkuldown = 0;

                anim.SetTrigger(animation);
            }
    }
}
