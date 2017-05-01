using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour {
    public Text text;
    public GameObject player;
    private int score;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        score = player.GetComponent<PlayerMovingController>().noPathsCrossed;
        if (score != 0)
            text.text = "Score: " + (score-1);
	}
}
