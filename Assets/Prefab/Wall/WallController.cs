using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour {
    public GameObject wall;
    private bool GoneDown = false;

	// Use this for initialization
	void Start () {

    }

    // Update is called once per frame
    void Update () {
        if (wall.transform.localPosition.y > 1 && !GoneDown)
            wall.transform.Translate(Vector3.down * 5 * Time.deltaTime);
        else
            GoneDown = true;

    }

    public void ClearWall()
    {
        wall.SetActive(false);
    }

    
}
