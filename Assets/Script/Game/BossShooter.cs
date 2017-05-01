using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShooter : MonoBehaviour {
    public GameObject bullet;
    public GameObject boss;
    public int health = 1000;
    public GameObject deathPrefab;
    public GameObject winScreen;

    private bool canShoot = true;

	// Use this for initialization
	void Start () {
        InvokeRepeating("Shoot", 2, .2f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Shoot()
    {
        if (canShoot && GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().movementAllowed)
        {
            var bulletCreate = Instantiate(bullet, boss.transform.position, boss.transform.rotation, null);
            bulletCreate.GetComponent<Rigidbody>().AddForce(bulletCreate.transform.forward * 500);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "PlayerBullet")
        {
            health -= 50;
            other.gameObject.SetActive(false);
            if (health == 0)
            {
                canShoot = false;
                die();
            }
        }
    }

    void die()
    {
        winScreen.SetActive(true);
        GameObject.FindWithTag("Player").GetComponent<PlayerController>().movementAllowed = false;
        Instantiate(deathPrefab, gameObject.transform.position, Quaternion.identity);
        canShoot = false;
        
    }

  
}
