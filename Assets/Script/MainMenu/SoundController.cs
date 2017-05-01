using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour {
    public Button button;
    public GameState gameState;

	// Use this for initialization
	void Start () {
        if (gameState.sound) button.image.color = Color.green;
        else button.image.color = Color.red;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Sound()
    {
        if (button.image.color == Color.green) button.image.color = Color.red;
        else button.image.color = Color.green;
    }
}
