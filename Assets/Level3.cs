using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOutAndDestroy3 : MonoBehaviour {

    public float stayTime = 3.0f;
    public float fadeoutTime = 1.0f;

    public Teleporter teleporter;

    private float time;

    public void Start() {
        time = stayTime + fadeoutTime;
    }

    void Update () {
        if (teleporter.destroy2 == true) {
        time -= Time.deltaTime;        

        if (time < fadeoutTime && time > 0) {
            float alpha  = time / fadeoutTime;
            foreach (CanvasRenderer r in GetComponentsInChildren<CanvasRenderer>()) {
                r.SetAlpha(alpha);
            }              
        }

        if (time <= 0) {
            Destroy(this.gameObject);
        } }
    }    
}