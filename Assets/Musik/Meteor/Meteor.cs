using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public float Geschwindichkeit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left*Geschwindichkeit*Time.deltaTime,Space.World);
        if(transform.position.x < -20){
            Destroy(gameObject);
        }
    }
}
