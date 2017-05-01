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


    /*-----------------------------------------------
    ENABLE
    -----------------------------------------------*/

    private void OnEnable()
    {
        //SET GAME CONTROLLER REFERENCE
        GameObject gameController = GameObject.FindWithTag("GameController");
        gameControlScript = gameController.GetComponent<GameControlScript>();
    }


    /*-----------------------------------------------
    START
    -----------------------------------------------*/
    // Use this for initialization
    void Start() {

        

        
        
	}   

    /*-----------------------------------------------
    UPDATE
    -----------------------------------------------*/
    // Update is called once per frame
    void Update () {

        //INTERPOLATE CAMERA MOVEMENT

        //--------------
        //SINGLE PLAYER
        //--------------
        if (gameControlScript.player1Choice == GameControlScript.Player1Character.Warrior) // player 1 is warrior
        {
            tempPos = Warrior.CameraPos; //follow warrior
        }

        if(gameControlScript.player1Choice == GameControlScript.Player1Character.Valkyrie) // player 1 is valkyrie
        {
            tempPos = Valkyrie.CameraPos; //follow valkyrie
        }

        if(gameControlScript.player1Choice == GameControlScript.Player1Character.Wizard) // player 1 is wizard
        {
            tempPos = Wizard.CameraPos; //follow wizard
        }

        if(gameControlScript.player1Choice == GameControlScript.Player1Character.Elf) // player 1 is elf
        {
            tempPos = Elf.CameraPos; //follow elf
        }

        //---------------
        //TWO PLAYER
        //---------------

        // warrior and valkyrie
        if(gameControlScript.player1Choice == GameControlScript.Player1Character.Warrior        //player 1 is warrior &&
            && gameControlScript.player2Choice == GameControlScript.Player2Character.Valkyrie)  //player 2 is valkyrie
        {
            tempPos.x = Mathf.Lerp(Warrior.CameraPos.x, Valkyrie.CameraPos.x, 0.5f); //Lerp between the two
            tempPos.z = Mathf.Lerp(Warrior.CameraPos.z, Valkyrie.CameraPos.z, 0.5f);
        }



        // warrior and wizard
        if(gameControlScript.player1Choice == GameControlScript.Player1Character.Warrior        //player 1 is warrior &&
            && gameControlScript.player2Choice == GameControlScript.Player2Character.Wizard)    //player 2 is wizard
        {
            tempPos.x = Mathf.Lerp(Warrior.CameraPos.x, Wizard.CameraPos.x, 0.5f); //Lerp between the two
            tempPos.z = Mathf.Lerp(Warrior.CameraPos.z, Wizard.CameraPos.z, 0.5f);
        }



        //warrior and elf
        if (gameControlScript.player1Choice == GameControlScript.Player1Character.Warrior   //player 1 is warrior &&
            && gameControlScript.player2Choice == GameControlScript.Player2Character.Elf)   //player 2 is elf
        {
            tempPos.x = Mathf.Lerp(Warrior.CameraPos.x, Elf.CameraPos.x, 0.5f); //Lerp between the two
            tempPos.z = Mathf.Lerp(Warrior.CameraPos.z, Elf.CameraPos.z, 0.5f);
        }
        


        // valkyrie and warrior
        if(gameControlScript.player1Choice == GameControlScript.Player1Character.Valkyrie       //player 1 is Valkyrie
            && gameControlScript.player2Choice == GameControlScript.Player2Character.Warrior)   //player 2 is warrior
        {
            tempPos.x = Mathf.Lerp(Valkyrie.CameraPos.x, Warrior.CameraPos.x, 0.5f); //Lerp between the two
            tempPos.z = Mathf.Lerp(Valkyrie.CameraPos.z, Warrior.CameraPos.z, 0.5f);
        }



        //valkyrie and wizard
        if (gameControlScript.player1Choice == GameControlScript.Player1Character.Valkyrie       //player 1 is Valkyrie
            && gameControlScript.player2Choice == GameControlScript.Player2Character.Wizard)    //player 2 is wizard
        {
            tempPos.x = Mathf.Lerp(Valkyrie.CameraPos.x, Wizard.CameraPos.x, 0.5f); //Lerp between the two
            tempPos.z = Mathf.Lerp(Valkyrie.CameraPos.z, Wizard.CameraPos.z, 0.5f);
        }



        //valkyrie and elf
        if (gameControlScript.player1Choice == GameControlScript.Player1Character.Valkyrie       //player 1 is Valkyrie
            && gameControlScript.player2Choice == GameControlScript.Player2Character.Elf)       //player 2 is elf
        {
            tempPos.x = Mathf.Lerp(Valkyrie.CameraPos.x, Elf.CameraPos.x, 0.5f); //Lerp between the two
            tempPos.z = Mathf.Lerp(Valkyrie.CameraPos.z, Elf.CameraPos.z, 0.5f);
        }

        //wizard and warrior
        if (gameControlScript.player1Choice == GameControlScript.Player1Character.Wizard            //player 1 is wizard
            && gameControlScript.player2Choice == GameControlScript.Player2Character.Warrior)       //player 2 is warrior
        {
            tempPos.x = Mathf.Lerp(Wizard.CameraPos.x, Warrior.CameraPos.x, 0.5f); //Lerp between the two
            tempPos.z = Mathf.Lerp(Wizard.CameraPos.z, Warrior.CameraPos.z, 0.5f);
        }



        //wizard and valkyrie
        if (gameControlScript.player1Choice == GameControlScript.Player1Character.Wizard       //player 1 is wizard
            && gameControlScript.player2Choice == GameControlScript.Player2Character.Valkyrie)  //player 2 is valkyrie
        {
            tempPos.x = Mathf.Lerp(Wizard.CameraPos.x, Valkyrie.CameraPos.x, 0.5f); //Lerp between the two
            tempPos.z = Mathf.Lerp(Wizard.CameraPos.z, Valkyrie.CameraPos.z, 0.5f);
        }



        //wizard and elf
        if (gameControlScript.player1Choice == GameControlScript.Player1Character.Wizard       //player 1 is wizard
            && gameControlScript.player2Choice == GameControlScript.Player2Character.Elf)   //player 2 is elf
        {
            tempPos.x = Mathf.Lerp(Wizard.CameraPos.x, Elf.CameraPos.x, 0.5f); //Lerp between the two
            tempPos.z = Mathf.Lerp(Wizard.CameraPos.z, Elf.CameraPos.z, 0.5f);
        }



        //elf and warrior
        if (gameControlScript.player1Choice == GameControlScript.Player1Character.Elf           //player 1 is elf
            && gameControlScript.player2Choice == GameControlScript.Player2Character.Warrior)  //player 2 is warrior
        {
            tempPos.x = Mathf.Lerp(Elf.CameraPos.x, Warrior.CameraPos.x, 0.5f); //Lerp between the two
            tempPos.z = Mathf.Lerp(Elf.CameraPos.z, Warrior.CameraPos.z, 0.5f);
        }


        
        //elf and valkyrie
        if (gameControlScript.player1Choice == GameControlScript.Player1Character.Elf           //player 1 is elf
            && gameControlScript.player2Choice == GameControlScript.Player2Character.Valkyrie)  //player 2 is valkyrie
        {
            tempPos.x = Mathf.Lerp(Elf.CameraPos.x, Valkyrie.CameraPos.x, 0.5f); //Lerp between the two
            tempPos.z = Mathf.Lerp(Elf.CameraPos.z, Valkyrie.CameraPos.z, 0.5f);
        }


        
        //elf and wizard
        if (gameControlScript.player1Choice == GameControlScript.Player1Character.Elf           //player 1 is elf
            && gameControlScript.player2Choice == GameControlScript.Player2Character.Wizard)  //player 2 is wizard
        {
            tempPos.x = Mathf.Lerp(Elf.CameraPos.x, Wizard.CameraPos.x, 0.5f); //Lerp between the two
            tempPos.z = Mathf.Lerp(Elf.CameraPos.z, Wizard.CameraPos.z, 0.5f);
        }


        
        transform.position = tempPos;
	}
}
