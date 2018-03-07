using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour {

    Rigidbody2D player;
    public Vector2 p1, p2, v;
    public float scale = 200f;
    public float xv;

    void Start () {
        player = GetComponent<Rigidbody2D>();
        

	}
	
	// Update is called once per frame
	void Update () {


        if (Input.GetMouseButtonDown(0))
        {
            p1 = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0))
        {
            p2 = Input.mousePosition;
            v = p2 - p1;
            Debug.Log(v);
            if(v.y > 170)
            {
                v.y = 170f;
            }
            player.velocity = new Vector2(0, v.y / scale);

        }
        
        
    }
}
