using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class voidScene : MonoBehaviour {

    public int intScore = 0;
    public Text valScore;
    public Button btnAmmo;
    public Button btnShield; 
    public KeyCode btnGunReload;
    public KeyCode btnShieldKey;
    public AudioClip gunReloadClip;

	// Use this for initialization
	void Start () {
        btnAmmo.interactable = false;
        btnShield.interactable = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (intScore > 99)
        {
            intScore = 99;
        } else if (intScore < 0)
        {
            intScore = 0;
        }

        valScore.text = "SCORE: " + intScore;

        if (intScore >= 60)
        {
            btnAmmo.interactable = true;
            if (Input.GetKeyDown(btnGunReload))
            {
                ReloadAmmo();
            }
        } else
        {
            btnAmmo.interactable = false;
        }

	}

    public void ReloadAmmo ()
    {

        int HeroeAmmo = GameObject.Find("Heroes_0").GetComponent<voidHeroe>().actualBullets;
        
        if (HeroeAmmo != 6) {
            GameObject.Find("Heroes_0").GetComponent<voidHeroe>().actualBullets = 6;
            intScore = intScore - 75;
            AudioSource.PlayClipAtPoint(gunReloadClip, GameObject.Find("Heroes_0").gameObject.GetComponent<Transform>().position);
        }
        
    }
}
