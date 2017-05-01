using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseBoss : MonoBehaviour {
    public GameObject player;
    public GameObject canvas;
    public GameObject boss;

    private bool canPause = false;

    // Use this for initialization
    void Start () {
        Invoke("MakePause", 5);
	}

    void MakePause()
    {
        canPause = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (canPause && (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P)))
        {
            canvas.SetActive(!canvas.activeInHierarchy);

            if (!player.GetComponent<PlayerController>().movementAllowed)
            {
                player.GetComponent<PlayerController>().canTakeDamage = true;
                player.GetComponent<PlayerController>().movementAllowed = true;
                boss.SetActive(true);
            }
            else
            {
                player.GetComponent<PlayerController>().canTakeDamage = false;
                player.GetComponent<PlayerController>().movementAllowed = false;
                boss.SetActive(false);
            }
        }
    }

    public void Resume()
    {
        canvas.SetActive(!canvas.activeInHierarchy);
        player.GetComponent<PlayerController>().movementAllowed = false;
        player.GetComponent<PlayerController>().canTakeDamage = true;
        boss.SetActive(true);
    }
}
