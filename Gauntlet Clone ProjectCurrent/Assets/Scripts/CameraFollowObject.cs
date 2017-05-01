using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowObject : MonoBehaviour {

    /*-----------------------------------------------
    DECLARATIONS
    -----------------------------------------------*/
    public static Vector3 tempPos;

    //game control reference variable
    GameControlScript gameControlScript;
    
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
        //SET GAME CONTROLLER REFERENCE
        GameObject gameController = GameObject.FindWithTag("GameController");
        gameControlScript = gameController.GetComponent<GameControlScript>();

	}

    /*-----------------------------------------------
    UPDATE
    -----------------------------------------------*/
    // Update is called once per frame
    void Update () {

        //interpolate
        if(gameControlScript.player1Character == 3 && gameControlScript.player2Character == 1)
        {
            tempPos.x = Mathf.Lerp(Warrior.CameraPos.x, Wizard.CameraPos.x, 0.5f);
            tempPos.z = Mathf.Lerp(Warrior.CameraPos.z, Wizard.CameraPos.z, 0.5f);

        }

        //tempPos = Warrior.CameraPos;

        transform.position = tempPos;
	}
}
