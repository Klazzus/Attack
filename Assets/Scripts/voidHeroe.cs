using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class voidHeroe : MonoBehaviour {

    public KeyCode ctrlKeyUp;
    public KeyCode ctrlKeyDown;
    public KeyCode ctrlKeyShot;
    public GameObject preBullet;
    public int actualBullets = 6;
    public int maxBullets = 6;
    public Text scoreBullets;
    int heroPosition = 0;
    float desplazamiento = 1.705f;
    public AudioClip EmptyGunClip;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(ctrlKeyShot))
        {

            if (actualBullets > 0)
            {
                Vector3 gunPosition = new Vector3(this.gameObject.GetComponent<Transform>().position.x - 0.3f, this.gameObject.GetComponent<Transform>().position.y - 0.2f, -1f);
                Instantiate(preBullet, gunPosition, Quaternion.identity);
                actualBullets = --actualBullets;
            }
            else
            {
                AudioSource.PlayClipAtPoint(EmptyGunClip, this.gameObject.GetComponent<Transform>().position); 
            }
            
        }

        scoreBullets.text = "BULLETS: " + actualBullets + "/" + maxBullets;

        if (Input.GetKeyDown(ctrlKeyUp) && heroPosition < 1)
        {
            transform.Translate(new Vector3(0, desplazamiento, 0));
            heroPosition = heroPosition + 1; 
        }

        if (Input.GetKeyDown(ctrlKeyDown) && heroPosition > -1)
        {
            transform.Translate(new Vector3(0, -desplazamiento, 0));
            heroPosition = heroPosition - 1;
        }
	}
}
