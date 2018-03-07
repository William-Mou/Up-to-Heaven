using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarFall : MonoBehaviour {
    public float velocity;

    void Start () {
        velocity = Random.Range(0.5f, 2.0f);
    }
	
	// Update is called once per frame
	void Update () {
        fallDown();
	}

    private void fallDown()
    {
        transform.Translate(0, -velocity * Time.deltaTime, 0);
    }

    
    /* private void spawn()
     {
         float x = Random.Range(-2.5f, 2.5f);
         Vector2 v = new Vector2(y, transform.position.y);
         Instantiate(score, v, Quaternion.identity);
     }*/
}
