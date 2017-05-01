using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointWall : MonoBehaviour {
    public GameObject trigger;

	// Use this for initialization
	void Start () {
        int spawn = Random.Range(0, 3);
        trigger.SetActive(true);

        if (spawn == 0)
            trigger.transform.localPosition = new Vector3(.3f, 0, 0);
        else if (spawn == 1)
            trigger.transform.localPosition = new Vector3(0, 0, 0);
        else if (spawn == 2)
            trigger.transform.localPosition = new Vector3(-.3f, 0, 0);


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
