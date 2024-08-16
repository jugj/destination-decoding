using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10;
    Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float yspeed = rigidbody.velocity.x;
        rigidbody.velocity = new Vector2(Input.GetAxis("Horizontal") *  speed, yspeed);
    }
}
