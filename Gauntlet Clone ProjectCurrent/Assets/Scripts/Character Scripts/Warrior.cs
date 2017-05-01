using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Warrior : BaseCharacter {


    /*-----------------------------------------------
    DECLARATIONS
    -----------------------------------------------*/

    //BASE WARRIOR VARIABLES
    private Vector3 startPos;
    private Vector3 tempPos;
    private Vector3 direction;

    //VARIABLE FOR CAMERA POS
    public static Vector3 CameraPos;

    //player death
    bool playerDead;

    

    /*-----------------------------------------------
     START
     -----------------------------------------------*/
    // Use this for initialization
    void Start () {
        startPos = transform.position;
        tempPos = transform.position;
        direction = transform.eulerAngles;



        //Invoke healthDrain
        InvokeRepeating("DrainHealth", 2f, 2f);
        
	}

    /*-----------------------------------------------
     UPDATE
     -----------------------------------------------*/
    // Update is called once per frame
    void Update () {


        

        //set CameraPos
        CameraPos = transform.position;



        //-----------------
        //KEYBOARD CONTROLS
        //-----------------

        //--------
        //MOVEMENT
        //--------

        //MOVE LEFT
        if(Input.GetKey("a"))
        {
            tempPos.x -= (moveSpeed * Time.deltaTime);
            direction = new Vector3(0, 270, 0); //direction = 270
            transform.eulerAngles = direction;
        }

        //MOVE RIGHT
        if(Input.GetKey("d"))
        {
            tempPos.x += (moveSpeed * Time.deltaTime);
            direction = new Vector3(0, 90, 0); //direction = 90
            transform.eulerAngles = direction;
        }

        //MOVE UP
        if(Input.GetKey("w"))
        {
            tempPos.z += (moveSpeed * Time.deltaTime);
            direction = new Vector3(0, 0, 0); //direction = 0
            transform.eulerAngles = direction;
        }

        //MOVE DOWN
        if(Input.GetKey("s"))
        {
            tempPos.z -= (moveSpeed * Time.deltaTime);
            direction = new Vector3(0, 180, 0); //direction = 180
            transform.eulerAngles = direction;
        }

        //-------
        //MOVE DIAGONAL
        //-------

        //UP AND LEFT
        if (Input.GetKey("a") && Input.GetKey("w"))
        {
            direction = new Vector3(0, 315, 0); //direction = 315
            transform.eulerAngles = direction;

            //if d is pressed while holding a and w
            if(Input.GetKey("d"))
            {
                direction = new Vector3(0, 0, 0); //direction = 0
                transform.eulerAngles = direction;
            }

            //if s is pressed while holding a and w
            if (Input.GetKey("s"))
            {
                direction = new Vector3(0, 270, 0); //direction = 270
                transform.eulerAngles = direction;
            }
        }

        //UP AND RIGHT
        if(Input.GetKey("d") && Input.GetKey("w"))
        {
            direction = new Vector3(0, 45, 0); //direction = 45
            transform.eulerAngles = direction;

            //if a is pressed while holding d and w
            if (Input.GetKey("a"))
            {
                direction = new Vector3(0, 0, 0); // direction = 0
                transform.eulerAngles = direction;
            }

            //if s is pressed while holding d and w
            if (Input.GetKey("s"))
            {
                direction = new Vector3(0, 90, 0); //direction = 90
                transform.eulerAngles = direction;
            }
        }

        //MOVE DOWN AND LEFT
        if(Input.GetKey("a") && Input.GetKey("s"))
        {
            direction = new Vector3(0, 225, 0); //direction = 225
            transform.eulerAngles = direction;

            // if d is pressed while holding a and s
            if(Input.GetKey("d"))
            {
                direction = new Vector3(0, 180, 0); // direction = 180
                transform.eulerAngles = direction;
            }

            //if w is pressed while holding a and s
            if (Input.GetKey("w"))
            {
                direction = new Vector3(0, 270, 0); // direction = 270
                transform.eulerAngles = direction;
            }
        }

        //MOVE DOWN AND RIGHT
        if(Input.GetKey("d") && Input.GetKey("s"))
        {
            direction = new Vector3(0, 135, 0); //direction = 135
            transform.eulerAngles = direction;
            
            //if "a" is pressed while holding "d" and "s"
            if(Input.GetKey("a"))
            {
                direction = new Vector3(0, 180, 0); //direction = 180
                transform.eulerAngles = direction;
            }

            //if "w" is pressed while holding "d" and "s"
            if (Input.GetKey("w"))
            {
                direction = new Vector3(0, 90, 0); // direction = 90
                transform.eulerAngles = direction;
            }

        }

        
        //----------------
        //GAMEPAD CONTROLS
        //----------------


        //transform.position = tempPos;
        

	}



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Food")
        {
            health += foodHealthIncrease;
            //print(health);
            
            if (health > 100)
            {
                health = 100;
               
            }
        }

        if (other.gameObject.tag == "Treasure")
        {
            randomTreasureIncrease = Random.Range(10, 51);
            treasureScore += randomTreasureIncrease;
        }

        if (other.gameObject.tag == "Key")
        {
            keyCount += 1;
            print(keyCount);
        }

        if (other.gameObject.tag == "Potion")
        {
            potionCount += 1;
        }
    }


    
    void DrainHealth()
    {
        //HEALTH DRAIN OVER TIME
        health -= healthDrain;
        print(health);
        if (health < 1)
        {
            playerDead = true;
        }
        //print(health);
    }
}
