using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameControlScript : MonoBehaviour {

    /*-----------------------------------------------
    DECLARATIONS
    -----------------------------------------------*/
    
    

    //Camera follow Object
    public GameObject CameraFollowObject;


    //PLAYER VARIABLES
    
    //bool to check for player existence
    public bool player1;
    public bool player2;
    public bool player3;
    public bool player4;

    //ints to assign character to player choice
    public int player1Character;
    public int player2Character;
    public int player3Character;
    public int player4Character;

    //player 1 character enum
    public enum Player1Character { Warrior, Valkyrie, Wizard, Elf}
    public Player1Character player1Choice;

    //player 2 character enum
    public enum Player2Character { Warrior, Valkyrie, Wizard, Elf}
    public Player2Character player2Choice;
    //player 3 character enum
    public enum Player3Character { Warrior, Valkyrie, Wizard, Elf}
    public Player3Character player3Choice;

    //player 4 character enum
    public enum Player4Character { Warrior, Valkyrie, Wizard, Elf}
    public Player4Character player4Choice;

    //GAME OBJECT REFERENCES
    public Warrior warrior;
    public Valkyrie valkyrie;
    public Wizard wizard;
    public Elf elf;
    

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
                warrior = Instantiate(warrior) as Warrior;
                player1Choice = Player1Character.Warrior;
            }

            //player 1 chose valkyrie
            if (player1Character == 2)
            {
                //instantiate valkyrie
                valkyrie = Instantiate(valkyrie) as Valkyrie;
                player1Choice = Player1Character.Valkyrie;
            }

            //player 1 chose wizard
            if(player1Character == 3)
            {
                //instantiate wizard
                wizard = Instantiate(wizard) as Wizard;
                player1Choice = Player1Character.Wizard;
            }

            //player 1 chose elf
            if(player1Character == 4)
            {
                //instantiate elf
                elf = Instantiate(elf) as Elf;
                player1Choice = Player1Character.Elf;
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
                warrior = Instantiate(warrior) as Warrior;
                player2Choice = Player2Character.Warrior;
            }

            //player 2 chose valkyrie
            if (player2Character == 2)
            {
                //instantiate valkyrie
                valkyrie = Instantiate(valkyrie) as Valkyrie;
                player2Choice = Player2Character.Valkyrie;
            }

            //player 2 chose wizard
            if (player2Character == 3)
            {
                //instantiate wizard
                wizard = Instantiate(wizard) as Wizard;
                player2Choice = Player2Character.Wizard;
            }

            //player 2 chose elf
            if (player2Character == 4)
            {
                //instantiate elf
                elf = Instantiate(elf) as Elf;
                player2Choice = Player2Character.Elf;
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
                warrior = Instantiate(warrior) as Warrior;
                player3Choice = Player3Character.Warrior;
            }

            //player 3 chose valkyrie
            if (player3Character == 2)
            {
                //instantiate valkyrie
                valkyrie = Instantiate(valkyrie) as Valkyrie;
                player3Choice = Player3Character.Valkyrie;
            }

            //player 3 chose wizard
            if (player3Character == 3)
            {
                //instantiate wizard
                wizard = Instantiate(wizard) as Wizard;
                player3Choice = Player3Character.Wizard;
            }

            //player 3 chose elf
            if (player3Character == 4)
            {
                //instantiate elf
                elf = Instantiate(elf) as Elf;
                player3Choice = Player3Character.Elf;
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
                warrior = Instantiate(warrior) as Warrior;
                player4Choice = Player4Character.Warrior;
            }

            //player 4 chose valkyrie
            if (player4Character == 2)
            {
                //instantiate valkyrie
                valkyrie = Instantiate(valkyrie) as Valkyrie;
                player4Choice = Player4Character.Valkyrie;
            }

            //player 4 chose wizard
            if (player4Character == 3)
            {
                //instantiate wizard
                wizard = Instantiate(wizard) as Wizard;
                player4Choice = Player4Character.Wizard;
            }

            //player 4 chose elf
            if (player4Character == 4)
            {
                //instantiate elf
                elf = Instantiate(elf) as Elf;
                player4Choice = Player4Character.Elf;
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
