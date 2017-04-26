using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Valkyrie : BaseCharacter {

    /*-----------------------------------------------
     DECLARATIONS
     -----------------------------------------------*/

    //BASE VALKYRIE VARIABLES
    private Vector3 startPos;
    private Vector3 tempPos;

    //VARIABLE FOR CAMERA POS
    public static Vector3 CameraPos;


    /*-----------------------------------------------
     START
     -----------------------------------------------*/
    // Use this for initialization
    void Start()
    {
        startPos = transform.position;
        tempPos = transform.position;
    }

    /*-----------------------------------------------
     UPDATE
     -----------------------------------------------*/
    // Update is called once per frame
    void Update()
    {

        //set CameraPos
        CameraPos = transform.position;



        //-----------------
        //KEYBOARD CONTROLS
        //-----------------

        //MOVE LEFT
        if (Input.GetKey("a"))
        {
            tempPos.x -= (moveSpeed * Time.deltaTime);

        }

        //MOVE RIGHT
        if (Input.GetKey("d"))
        {
            tempPos.x += (moveSpeed * Time.deltaTime);
        }

        //MOVE UP
        if (Input.GetKey("w"))
        {
            tempPos.z += (moveSpeed * Time.deltaTime);
        }

        //MOVE DOWN
        if (Input.GetKey("s"))
        {
            tempPos.z -= (moveSpeed * Time.deltaTime);
        }


        //----------------
        //GAMEPAD CONTROLS
        //----------------


        transform.position = tempPos;

    }
}
