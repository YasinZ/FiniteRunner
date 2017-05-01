using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour {
    public Button button;
    public GameState gameState;

	// Use this for initialization
	void Start () {
        if (gameState.dynamicSpeed)
            button.image.color = Color.green;
        else
            button.image.color = Color.red;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SwapColor()
    {
        if (button.image.color == Color.green) button.image.color = Color.red;
        else button.image.color = Color.green;
    
    }
}
