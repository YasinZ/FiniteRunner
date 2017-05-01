using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour {
    public GameObject player;
    public GameObject canvas;
    public GameState gameState;

    private float prevSpeed;

    // Use this for initialization
    void Start() {
        prevSpeed = player.GetComponent<PlayerMovingController>().speed;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            canvas.SetActive(!canvas.activeInHierarchy);

            if (player.GetComponent<PlayerMovingController>().speed == 0)
            {
                player.GetComponent<PlayerMovingController>().speed = prevSpeed;
            }
            else
            {
                player.GetComponent<PlayerMovingController>().speed = 0;
            }
        }
	}

    public void Resume()
    {
        canvas.SetActive(!canvas.activeInHierarchy);
        player.GetComponent<PlayerMovingController>().speed = gameState.difficulty;
    }
}
