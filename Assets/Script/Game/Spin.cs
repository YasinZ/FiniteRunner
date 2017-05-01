using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour {
    public GameObject key;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        key.transform.Rotate(Vector3.up, 300 * Time.deltaTime);
    }
}
