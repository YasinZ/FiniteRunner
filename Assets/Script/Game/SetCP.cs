﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCP : MonoBehaviour {
    public GameState gameState;
    public GameObject CP;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            CP.GetComponent<MeshRenderer>().enabled = true;
            gameState.hitCP = true;
        }
    }
}
