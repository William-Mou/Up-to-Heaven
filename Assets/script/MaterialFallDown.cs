using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialFallDown : MonoBehaviour {

    public GameObject plat;
    public GameObject spawnpoint;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "plat")
        {
            float x = Random.Range(-2.5f, 2.5f);
            Vector2 newPlat = new Vector2(x, spawnpoint.transform.position.y);
            Instantiate(plat, newPlat, Quaternion.identity);
            Destroy(collision.gameObject);
        }
    }
}
