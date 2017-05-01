using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateGap : MonoBehaviour {
    public GameObject obstacle;

	// Use this for initialization
	void Start () {
        float localZ = GetComponent<Transform>().position.z;
        
        Vector3 p1 = new Vector3(-.7f, .1f, localZ);
        Vector3 p2 = new Vector3(0, .1f, localZ);
        Vector3 p3 = new Vector3(.7f, .1f, localZ);
        Vector3 p4 = new Vector3(.4f, .1f, localZ);
        Vector3 p5 = new Vector3(-.4f, .1f, localZ);

        Vector3[] p = { p1, p2, p3, p4, p5 };

        int rand = Random.Range(0, 5);
        Instantiate(obstacle, p[rand], Quaternion.identity);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
