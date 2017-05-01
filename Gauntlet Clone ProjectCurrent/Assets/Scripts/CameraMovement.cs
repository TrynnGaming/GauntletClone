using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    /*-----------------------------------------------
    DECLARATIONS
    -----------------------------------------------*/
    Vector3 tempPos;



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

        //set camera position to update with position of CameraFollowObject

        

        tempPos.z = CameraFollowObject.tempPos.z - 8; //need to update the value with a variable when possible
        tempPos.x = CameraFollowObject.tempPos.x;
        tempPos.y = 12;                               //update with variable when possible
        transform.position = tempPos;
	}
}
