using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public float Spawnrate;
    private float zeit = 0;
    public Meteor meteor;

    
    void SpawnObject(){
        float y_pos = Random.Range(-5f, 5f);
        Vector2 position=new Vector2(13f,y_pos);
        Instantiate(meteor,position,Quaternion.identity);

     }

    // Start is called before the first frame update
    void Start()
    {
        SpawnObject();
    }

    // Update is called once per frame
    void Update()
    {
        if(zeit > Spawnrate)
        {
            SpawnObject();
            zeit = 0;
        }
        else
        {
            zeit = zeit + Time.deltaTime;
        }
    }
}
