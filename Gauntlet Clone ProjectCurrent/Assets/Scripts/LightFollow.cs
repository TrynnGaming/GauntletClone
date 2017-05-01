using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFollow : MonoBehaviour {

    public static Vector3 tempPos;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        tempPos.x = Warrior.CameraPos.x;
        tempPos.z = Warrior.CameraPos.z;
        tempPos.y = 10f;
        transform.position = tempPos;
    }
}
