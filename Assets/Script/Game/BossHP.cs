using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHP : MonoBehaviour {
    public GameObject boss;
    public Text text;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        text.text = "BOSS HEALTH: " + boss.GetComponent<BossShooter>().health;
	}
}
