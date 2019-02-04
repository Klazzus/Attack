using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class voidBus : MonoBehaviour {

    public int Life;
    public Text Marcador;


	// Use this for initialization
	void Start () {
        //Life = 100;
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Life <= 0)
        {
            DestroyObject(this.gameObject);
            Marcador.text = "<3 : 0 / 100";
            GameObject.Find("btnStart").GetComponent<Transform>().localScale = new Vector3(1f, 1f, 1f);
        } else
        {
            Marcador.text = "<3 : " + Life + " / 100";
        }

	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            Life = Life - collision.gameObject.GetComponent<voidZomb>().force; 
        }
    }
}
