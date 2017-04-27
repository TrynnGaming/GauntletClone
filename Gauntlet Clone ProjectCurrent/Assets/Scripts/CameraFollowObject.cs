using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowObject : MonoBehaviour {

    /*-----------------------------------------------
    DECLARATIONS
    -----------------------------------------------*/
    public static Vector3 tempPos;

    

    private void OnEnable()
    {
        //possibly try to get a reference to each class
        //to set local variables in order check variables 
        //from those classes
        //can help with setting the camera in the future
    }


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
        tempPos = Warrior.CameraPos;
        transform.position = tempPos;
	}
}
