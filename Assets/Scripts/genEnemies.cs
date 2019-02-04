using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class genEnemies : MonoBehaviour {


    public GameObject preZomb;
    float Dificult = 5;
    bool Started = false;

    float secondsCounter = 0f;
    float secondsToCount = 0f;

    // Use this for initialization
    void Start()
    {

    }

    void HardDificult()
    {
        if (Dificult > 0.75)
        {
            Dificult -= 0.25f;
            Debug.Log("HARDER" + Dificult);
        }
    }

    public void instZomb()
    {
        //Random.Range(-2.13f, 1.27f);

        int path =  Random.Range(1, 4);
        float posPath = 0f;

        switch (path)
        {
            case 1: posPath = -2.13f;
                break;
            case 2: posPath = -0.43f;
                break;
            case 3: posPath = 1.27f;
                break;
            default: posPath = 1.27f;
                break;
        }

        Instantiate(preZomb, new Vector3(-11.32f, posPath, -1), Quaternion.identity);
    }

    public void sleepInstZomb()
    {

        if (Started != true)
        {
            Started = true;
            InvokeRepeating("HardDificult", 0.0f, 10f);
            instZomb();
        }

        //InvokeRepeating("instBomb", 0.3f, Dificult);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.deltaTime + " sec.");

        if (Started == true)
        {
            GameObject.Find("btnStart").GetComponent<Transform>().localScale = new Vector3 (0,0,0); 

            secondsToCount = Dificult;
            secondsCounter = secondsCounter + Time.deltaTime;
            if (secondsCounter >= secondsToCount)
            {
                instZomb();
                secondsCounter = 0;
            }
        }

        //Debug.Log(" Dificultad "+ Dificult +" Tiempo contado " + secondsCounter + " Tiempo a contar " + secondsToCount + "");
    }


}
