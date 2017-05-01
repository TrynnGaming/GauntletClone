using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacter : MonoBehaviour {


    /*-----------------------------------------------
    DECLARATIONS
    -----------------------------------------------*/

    //BASE CHARACTER STATS
    public float health;
    public float armor;
    public float moveSpeed;
    public float damage;
    [HideInInspector] public float totalDamage;
    public float magic;

    //total damage == damage - (armor *.1)

    //health drain
    public int healthDrain;

    //health food increase
    public int foodHealthIncrease;

    //treasure
    public int treasureScore;
    [HideInInspector] public int randomTreasureIncrease;

    //keys
    public int keyCount;
    //potions
    public int potionCount;


    


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

         
	}



    

}
