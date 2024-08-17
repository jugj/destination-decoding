using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimPlayerTest : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)){
            anim.SetTrigger("dash_right");
        }
        if(Input.GetKeyDown(KeyCode.L)){
            anim.SetTrigger("dash_left");
        }
        if(Input.GetKeyDown(KeyCode.A)){
            anim.SetTrigger("attack_right");
        }
        if(Input.GetKeyDown(KeyCode.B)){
            anim.SetTrigger("attack_left");
        }
    }
}
