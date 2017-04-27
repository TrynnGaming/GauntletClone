using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlScript : MonoBehaviour {

    /*-----------------------------------------------
    DECLARATIONS
    -----------------------------------------------*/
    
    //GAME OBJECT REFERENCES
    public GameObject WarriorObject;
    public GameObject ValkyrieObject;
    public GameObject WizardObject;
    public GameObject ElfObject;


    //Camera follow Object
    public GameObject CameraFollowObject;


    //PLAYER VARIABLES
    
    //bool to check for player existence
    bool player1;
    bool player2;
    bool player3;
    bool player4;

    //ints to assign character to player choice
    int player1Character;
    int player2Character;
    int player3Character;
    int player4Character;


    void OnEnable()
    {
        //set check for if controllers are plugged in!!!!
        //if they are plugged in set player bool variables accordingly


        //TEST** 
        player1 = true;
        player2 = true;
        player1Character = 1;
        player2Character = 3;
        //ENDTEST**

    }


    /*-----------------------------------------------
    START
    -----------------------------------------------*/

    void Start()
    {
        //-----------------
        //PLAYER 1 CONNECTED
        //-----------------
        if (player1)
        {
            //player 1 chose warrior
            if (player1Character == 1)
            {
                //instantiate warrior
                Instantiate(WarriorObject);
            }

            //player 1 chose valkyrie
            if (player1Character == 2)
            {
                //instantiate valkyrie
                Instantiate(ValkyrieObject);
            }

            //player 1 chose wizard
            if(player1Character == 3)
            {
                //instantiate wizard
                Instantiate(WizardObject);
            }

            //player 1 chose elf
            if(player1Character == 4)
            {
                //instantiate elf
                Instantiate(ElfObject);
            }
        }

        //-----------------
        //PLAYER 2 CONNECTED
        //-----------------
        if (player2)
        {
            //player 2 chose warrior
            if (player2Character == 1)
            {
                //instantiate warrior
                Instantiate(WarriorObject);
            }

            //player 2 chose valkyrie
            if (player2Character == 2)
            {
                //instantiate valkyrie
                Instantiate(ValkyrieObject);
            }

            //player 2 chose wizard
            if (player2Character == 3)
            {
                //instantiate wizard
                Instantiate(WizardObject);
            }

            //player 2 chose elf
            if (player2Character == 4)
            {
                //instantiate elf
                Instantiate(ElfObject);
            }
        }

        //-----------------
        //PLAYER 3 CONNECTED
        //-----------------
        if(player3)
        {
            //player 3 chose warrior
            if (player3Character == 1)
            {
                //instantiate warrior
                Instantiate(WarriorObject);
            }

            //player 3 chose valkyrie
            if (player3Character == 2)
            {
                //instantiate valkyrie
                Instantiate(ValkyrieObject);
            }

            //player 3 chose wizard
            if (player3Character == 3)
            {
                //instantiate wizard
                Instantiate(WizardObject);
            }

            //player 3 chose elf
            if (player3Character == 4)
            {
                //instantiate elf
                Instantiate(ElfObject);
            }
        }

        //-----------------
        //PLAYER 4 CONNECTED
        //-----------------
        if(player4)
        {
            //player 4 chose warrior
            if (player4Character == 1)
            {
                //instantiate warrior
                Instantiate(WarriorObject);
            }

            //player 4 chose valkyrie
            if (player4Character == 2)
            {
                //instantiate valkyrie
                Instantiate(ValkyrieObject);
            }

            //player 4 chose wizard
            if (player4Character == 3)
            {
                //instantiate wizard
                Instantiate(WizardObject);
            }

            //player 4 chose elf
            if (player4Character == 4)
            {
                //instantiate elf
                Instantiate(ElfObject);
            }
        }

        //Instantiate(ValkyrieObject);
        //Instantiate(WizardObject);
        //Instantiate(ElfObject);

        //instantiate the camera follow object
        Instantiate(CameraFollowObject);
    }

    /*-----------------------------------------------
    UPDATE
    -----------------------------------------------*/

    // Update is called once per frame
    void Update () {
		
	}
}
