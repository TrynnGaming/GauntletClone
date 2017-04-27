using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePickup : MonoBehaviour {


    /*-----------------------------------------------
    DECLARATIONS
    -----------------------------------------------*/

    //BASE PICKUP VARIABLES
    private enum PickupType { Food, Treasure, Key, Potion};
    private PickupType pickuptype;
    bool food;
    bool treasure;
    bool key;
    bool potion;


    /*-----------------------------------------------
    START
    -----------------------------------------------*/

    // Use this for initialization
    void Start () {
		if(food)
        {
            pickuptype = PickupType.Food;
        }

        if(treasure)
        {
            pickuptype = PickupType.Treasure;
        }

        if(key)
        {
            pickuptype = PickupType.Key;
        }

        if(potion)
        {
            pickuptype = PickupType.Potion;
        }
	}

    /*-----------------------------------------------
    UPDATE
    -----------------------------------------------*/

    // Update is called once per frame
    void Update () {
		
	}
}
