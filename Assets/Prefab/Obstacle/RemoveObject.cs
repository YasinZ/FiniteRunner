using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveObject : MonoBehaviour {
    public GameObject obj;
    public int time = 5;

	// Use this for initialization
	void Start () {
        Destroy(obj, time);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
