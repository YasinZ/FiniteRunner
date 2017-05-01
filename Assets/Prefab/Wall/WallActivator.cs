using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallActivator : MonoBehaviour {

    public WallController wall;

	// Use this for initialization
	void Start () {

    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        wall.ClearWall();
    }
}
