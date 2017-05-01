using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObstacle : MonoBehaviour {
    public GameObject[] prefabs;

    private Vector3 spawnPoint;

    private float[] spawnPoint1 = { 7f,  35f, -4f, 4f};
    private float[] spawnPoint2 = { -7f, -35f, -4f, 4f };
    private float[] spawnPoint3 = { -34f, 34f, -7f, -35f };
    private float[] spawnPoint4 = { -34f, 34f, 7f, 35f };

    // Use this for initialization
    void Start () {
        if(gameObject.name == "GenerateObstacle1")
        {
            for (int i = 0; i < 40; i++)
            {
                spawnPoint = new Vector3(Random.Range(spawnPoint1[0], spawnPoint1[1]), 0.5f, Random.Range(spawnPoint1[2], spawnPoint1[3]));
                Instantiate(prefabs[Random.Range(0, 3)], spawnPoint, Quaternion.identity);
            }
        }
        else if (gameObject.name == "GenerateObstacle2")
        {
            for (int i = 0; i < 40; i++)
            {
                spawnPoint = new Vector3(Random.Range(spawnPoint2[0], spawnPoint2[1]), 0.5f, Random.Range(spawnPoint2[2], spawnPoint2[3]));
                Instantiate(prefabs[Random.Range(0, 3)], spawnPoint, Quaternion.identity);
            }
        }
        else if (gameObject.name == "GenerateObstacle3")
        {
            for (int i = 0; i < 200; i++)
            {
                spawnPoint = new Vector3(Random.Range(spawnPoint3[0], spawnPoint3[1]), 0.5f, Random.Range(spawnPoint3[2], spawnPoint3[3]));
                Instantiate(prefabs[Random.Range(0, 3)], spawnPoint, Quaternion.identity);
            }
        }
        else if (gameObject.name == "GenerateObstacle4")
        {
            for (int i = 0; i < 200; i++)
            {
                spawnPoint = new Vector3(Random.Range(spawnPoint4[0], spawnPoint4[1]), 0.5f, Random.Range(spawnPoint4[2], spawnPoint4[3]));
                Instantiate(prefabs[Random.Range(0, 3)], spawnPoint, Quaternion.identity);
            }
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
