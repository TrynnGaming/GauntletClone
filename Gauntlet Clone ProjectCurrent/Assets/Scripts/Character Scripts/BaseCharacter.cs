using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacter : MonoBehaviour {


    /*-----------------------------------------------
    DECLARATIONS
    -----------------------------------------------*/

    //BASE CHARACTER STATS
    public float health;
    public int armor;
    public float moveSpeed;
    public float damage;
    public int magic;
    public float healthDrain;
    

    /*-----------------------------------------------
    START
    -----------------------------------------------*/

    // Use this for initialization
    void Start () {
		
	}

    /*-----------------------------------------------
    UPDATE
    -----------------------------------------------*/
    // Update is called once per frame
    void Update () {

        //HEALTH DRAIN OVER TIME
        health -= healthDrain * Time.deltaTime; 
	}
}
