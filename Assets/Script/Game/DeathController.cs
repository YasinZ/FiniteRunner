using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathController : MonoBehaviour {

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovingController>().die();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //SceneManager.LoadScene("MainGame");
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.collider.name == "Player")
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovingController>().die();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //SceneManager.LoadScene("MainGame");
        }
    }

}
