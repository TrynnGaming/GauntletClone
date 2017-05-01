using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFollow : MonoBehaviour {

    Vector3 tempPos;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        tempPos.x = CameraFollowObject.tempPos.x;
        tempPos.z = CameraFollowObject.tempPos.z;
        tempPos.y = 10f;
        transform.position = tempPos;
    }
}
