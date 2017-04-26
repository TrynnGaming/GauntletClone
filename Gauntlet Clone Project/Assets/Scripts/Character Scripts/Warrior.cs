using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : BaseCharacter {


    /*-----------------------------------------------
    DECLARATIONS
    -----------------------------------------------*/

    //BASE WARRIOR VARIABLES
    private Vector3 startPos;
    private Vector3 tempPos;

    // Use this for initialization
    void Start () {
        startPos = transform.position;
        tempPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		

        //-----------------
        //KEYBOARD CONTROLS
        //-----------------

        //MOVE LEFT
        if(Input.GetKey("a"))
        {
            tempPos.x -= (moveSpeed * Time.deltaTime);

        }

        //MOVE RIGHT
        if(Input.GetKey("d"))
        {
            tempPos.x += (moveSpeed * Time.deltaTime);
        }

        //MOVE UP
        if(Input.GetKey("w"))
        {
            tempPos.z += (moveSpeed * Time.deltaTime);
        }

        //MOVE DOWN
        if(Input.GetKey("s"))
        {
            tempPos.z -= (moveSpeed * Time.deltaTime);
        }


        //----------------
        //GAMEPAD CONTROLS
        //----------------


        transform.position = tempPos;

	}
}
