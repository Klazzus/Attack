using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voidZomb : MonoBehaviour {

    public Rigidbody2D rb;
    public GameObject preExplosion;
    public int force = 1;
    public GameObject valueText;

    // Use this for initialization
    void Start () {
        float speed = Random.Range(1.5f, 2.5f);
        rb.velocity = new Vector3(speed, 0, 0);
        if (speed < 1.8)
        {
            force = 3;
        }
        else if (speed > 2.2)
        {
            force = 1;
        } else
        {
            force = 2;
        }

        valueText.GetComponent<TextMesh>().text = ""+force; 
    }
	
	// Update is called once per frame
	void Update () {
		
	}




    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag != "Bomb")
        {
            Debug.Log("Colision");
            DestroyObject(this.gameObject);
            Vector3 posExplosion = this.gameObject.transform.position;
            //Instantiate(preExplosion, posExplosion, Quaternion.identity);
        }

        if (collision.gameObject.layer == 9)
        {
            GameObject.Find("SceneObjects").GetComponent<voidScene>().intScore = GameObject.Find("SceneObjects").GetComponent<voidScene>().intScore + (5 * force);
        }

        if (collision.gameObject.layer == 12)
        {
            GameObject.Find("SceneObjects").GetComponent<voidScene>().intScore = GameObject.Find("SceneObjects").GetComponent<voidScene>().intScore + 3;
        }
    }

}
