using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject WarriorObject;
    public GameObject ValkyrieObject;
    public GameObject WizardObject;
    public GameObject ElfObject;

	// Use this for initialization
	void Start () {
        Instantiate(WarriorObject);
        Instantiate(ValkyrieObject);
        Instantiate(WizardObject);
        Instantiate(ElfObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
