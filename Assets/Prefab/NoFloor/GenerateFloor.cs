using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateFloor : MonoBehaviour {
    public GameObject obj;

	// Use this for initialization
	void Start () {
        float[] spawnPoints = { -.78f, -.4f, 0, .4f, .78f };
        int rand = Random.Range(0, 5);

        Instantiate(obj, new Vector3(spawnPoints[rand], 0, this.transform.position.z), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
