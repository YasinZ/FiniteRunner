using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour {
    public GameObject bullet;
    public GameObject player;
    public bool waitForBoss;
    public int totalBullets;
    public int ammo = 3;

	// Use this for initialization
	void Start () {
        waitForBoss = true;
        Invoke("AllowShoot", 5);
	}

    void AllowShoot()
    {
        waitForBoss = false;
    }
	
	// Update is called once per frame
	void Update () {
		if(!waitForBoss && Input.GetKeyDown(KeyCode.Mouse0) && totalBullets < 3)
        {
            Shoot();
        }
	}

    void Shoot()
    {
        var bulletCreate = Instantiate(bullet, player.transform.position, player.transform.rotation, null);
        bulletCreate.GetComponent<Rigidbody>().AddForce(bulletCreate.transform.forward*500);
        totalBullets++;
        ammo--;
        Invoke("Dec", 1);
    }

    void Dec()
    {
        totalBullets--;
        ammo++;
    }
}
