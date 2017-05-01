using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeathController : MonoBehaviour {
    public Text text;
    public GameObject player;
    public GameObject canvas;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(player.GetComponent<PlayerController>().health == 0)
        {
            canvas.SetActive(false);
        }
        text.text = "Health: " + player.GetComponent<PlayerController>().health;
	}
}
