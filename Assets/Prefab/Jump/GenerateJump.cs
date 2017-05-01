using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateJump : MonoBehaviour {
    public GameObject obj;

	// Use this for initialization
	void Start () {
        int rand = Random.Range(0, 7);
        float xVal = 0;

        if (rand == 0) xVal = -.75f;
        else if (rand == 1) xVal = -.5f;
        else if (rand == 2) xVal = -.25f;
        else if (rand == 3) xVal = 0f;
        else if (rand == 4) xVal = .25f;
        else if (rand == 5) xVal = .5f;
        else if (rand == 6) xVal = .75f;

        Vector3 pos = new Vector3(xVal, 0.01f, this.gameObject.transform.position.z + .1f);

        Instantiate(obj, pos, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
