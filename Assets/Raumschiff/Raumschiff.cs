using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raumschiff : MonoBehaviour
{
    public float Geschwindichkeit;

<<<<<<< HEAD
        public int maxleben = 5;
        public int jetztleben;

        public Lebensanzeige lebensanzeige;
=======
    // setze Lebenswerte
    public int maxleben = 10;
    public int leben;


    public Healthbar Healthbar;
>>>>>>> 370dd4465b3e42ce2292eeb087d01e89ca2eb082

    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD
        jetztleben = maxleben;
        lebensanzeige.setzemaxleben(maxleben);
=======
        leben = maxleben;
        Healthbar.SetzeMaxLeben(maxleben);
>>>>>>> 370dd4465b3e42ce2292eeb087d01e89ca2eb082
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
<<<<<<< HEAD
        
        jetztleben-=1;
        lebensanzeige.setzeleben(jetztleben);
=======
>>>>>>> 370dd4465b3e42ce2292eeb087d01e89ca2eb082
        Destroy(other.gameObject);

        // Leben abziehen
        leben -= 1;
        Healthbar.SetzeLeben(leben);

    }
}
