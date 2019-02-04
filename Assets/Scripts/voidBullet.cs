using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voidBullet : MonoBehaviour {

    public float bulletVelocity = 10; 

	// Use this for initialization
	void Start () {
		this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(-bulletVelocity, 0, 0);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyObject(this.gameObject);
    }
}
