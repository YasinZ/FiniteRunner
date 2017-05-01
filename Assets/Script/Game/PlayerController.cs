using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public float speed = 10f;
    public float offSet = 100f;
    public int health = 100;
    public GameObject boss;
    public GameObject deathPrefab;
    public GameObject deathScreen;
    public GameObject finalBoss;

    public bool canTakeDamage = true;
    public bool movementAllowed = true;

    // Use this for initialization
    void Start () {
        movementAllowed = false;
        playBoss();
	}

    // Update is called once per frame
    void Update() {
        if (movementAllowed)
        {
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
                //transform.Translate(Vector3.left * speed * Time.deltaTime);
                transform.Translate(Vector3.left * speed * Time.deltaTime);

            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
                //transform.Translate(Vector3.right * speed * Time.deltaTime);
                transform.Translate(Vector3.right * speed * Time.deltaTime);

            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
                transform.Translate(Vector3.forward * speed * Time.deltaTime);

            if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
                transform.Translate(Vector3.back * speed * Time.deltaTime);

            if (Input.GetKey(KeyCode.Q))
                transform.Rotate(Vector3.down * speed * offSet * Time.deltaTime);

            if (Input.GetKey(KeyCode.E))
                transform.Rotate(Vector3.up * speed * offSet * Time.deltaTime);

        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Wall" && (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)))
        {
            transform.Translate(Vector3.back * speed * 20 * Time.deltaTime);
            transform.Translate(Vector3.up * speed * Time.deltaTime);

        }

        if (other.collider.tag == "Wall" && (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)))
        {
            transform.Translate(Vector3.forward * speed * 20 * Time.deltaTime);
            transform.Translate(Vector3.up * speed * Time.deltaTime);

        }

        if (other.collider.tag == "Box" && (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)))
        {
            transform.Translate(Vector3.back * speed * 2 * Time.deltaTime);
            transform.Translate(Vector3.up * 2f * Time.deltaTime);

        }

        if (other.collider.tag == "Box" && (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)))
        {
            transform.Translate(Vector3.forward * speed * 2 * Time.deltaTime);
            transform.Translate(Vector3.up * 2f * Time.deltaTime);

        }


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "EnemyBullet" && canTakeDamage)
        {
            other.gameObject.SetActive(false);
            health -= 10;

            if(health == 0)
            {
                die();
                canTakeDamage = false;
            }
        }
    }

    void playBoss()
    {
        if (boss != null)
        {
            InvokeRepeating("flashBoss", 2, .2f);
        }
        Invoke("DestoryBoss", 4.7f);
    }

    void flashBoss()
    {
        boss.SetActive(!boss.activeInHierarchy);
    }

    void DestoryBoss()
    {
        Destroy(boss);
        CreateBoss();
    }

    void CreateBoss()
    {
        finalBoss.SetActive(true);
        movementAllowed = true;
    }

    void die()
    {
        deathScreen.SetActive(true);
        movementAllowed = false;
        gameObject.GetComponent<Rigidbody>().useGravity = false;
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        Instantiate(deathPrefab, gameObject.transform.position, Quaternion.identity);
    }
}
