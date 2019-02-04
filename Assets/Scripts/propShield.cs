using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propShield : MonoBehaviour {

    public int shield;
    //public GameObject Test;
    public int Damage = 1;
    public GameObject valueText;

    // Use this for initialization
    void Start() {
        //shield = Random.Range(3,11);
        shield = 10;
    }

    // Update is called once per frame
    void Update() {
        if (shield <=0)
        {
            DestroyObject(this.gameObject);
        }
        valueText.GetComponent<TextMesh>().text = "" + shield;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //collision.gameObject.tag != "Bomb"
        if (collision.gameObject.layer == 8)
        {
            //Damage = Test.GetComponent<voidZomb>;
            Damage = collision.gameObject.GetComponent<voidZomb>().force;
            Debug.Log("Colison con enemigo, Daño:" + Damage);
            //shield = shield - collision.gameObject.GetComponent<voidZomb>.force;
            shield = shield - Damage;
        }
    }

}
