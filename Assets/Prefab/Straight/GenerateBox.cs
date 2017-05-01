using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBox : MonoBehaviour {
    public GameObject obj;

	// Use this for initialization
	void Start () {
        float[] spawnpoints = { .75f, .25f, -.25f, -.75f };

        int rand = Random.Range(0, 4);

        for (int i = 0; i < spawnpoints.Length; i++)
            if (i != rand)
                Instantiate(obj, new Vector3(spawnpoints[i], .25f, this.gameObject.transform.position.z), Quaternion.identity);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
