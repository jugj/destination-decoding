using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raumschiff : MonoBehaviour
{
    public float Geschwindichkeit;

    // setze Lebenswerte
    public int maxleben = 10;
    public int leben;


    public Healthbar Healthbar;

    // Start is called before the first frame update
    void Start()
    {
        leben = maxleben;
        Healthbar.SetzeMaxLeben(maxleben);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w")){
                transform.Translate(Vector2.up*Geschwindichkeit*Time.deltaTime,Space.World);
        }
        if(Input.GetKey("s")){
                transform.Translate(Vector2.down*Geschwindichkeit*Time.deltaTime,Space.World);
        }
        if(Input.GetKey("d")){
                transform.Translate(Vector2.right*Geschwindichkeit*Time.deltaTime,Space.World);
        }
        if(Input.GetKey("a")){
                transform.Translate(Vector2.left*Geschwindichkeit*Time.deltaTime,Space.World);
        }        
    }

    void OnTriggerEnter2D(Collider2D other){
        Destroy(other.gameObject);

        // Leben abziehen
        leben -= 1;
        Healthbar.SetzeLeben(leben);

    }
}
