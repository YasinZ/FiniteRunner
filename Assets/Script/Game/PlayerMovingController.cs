using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovingController : MonoBehaviour
{
    public float speed = 10f;
    public int noPathsCrossed;
    public bool hitCheckPoint;
    public GameState gameState;
    public GameObject canvas;
    public GameObject deathPrefab;

    private bool canMoveLeft = true;
    private bool canMoveRight = true;
    private bool movementAllowed = true;

    // Use this for initialization
    void Start()
    {
        speed = gameState.difficulty;
        hitCheckPoint = gameState.hitCP;
        if (hitCheckPoint) noPathsCrossed = (int)(gameState.difficulty * 2.5) + 1;
        movementAllowed = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.R))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        if (movementAllowed)
        {
            // Constant move forward
            transform.Translate(Vector3.forward * speed * Time.deltaTime);

            // 
            if ((Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) && canMoveRight)
                transform.Translate(Vector3.right * 3 * Time.deltaTime);

            if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) && canMoveLeft)
                transform.Translate(Vector3.left * 3 * Time.deltaTime);

            if (gameState.dynamicSpeed && (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)))
                if (speed <= 15) speed++; else speed = 15;

            if (gameState.dynamicSpeed && (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)))
                if (speed >= 5) speed--; else speed = 5;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "LeftWall")
        {
            canMoveLeft = false;
            canMoveRight = true;
            transform.Translate(Vector3.right * 3 * Time.deltaTime);

        }

        if (other.collider.tag == "RightWall")
        {
            canMoveRight = false;
            canMoveLeft = true;
            transform.Translate(Vector3.left * 3 * Time.deltaTime);

        }

    }
    // work here to avoid clipping via checking pos vs objects perhapsd
    // reset player posff
    void OnCollisionExit(Collision other)
    {
        if (other.collider.tag == "LeftWall")
        {
            canMoveLeft = true;
            canMoveRight = true;
        }

        if (other.collider.tag == "RightWall")
        {
            canMoveLeft = true;
            canMoveRight = true;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "JumpZone" && (Input.GetKeyDown(KeyCode.Space) || Input.GetKey(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKey(KeyCode.UpArrow)))
        {
            //while (transform.localPosition.y < 1.5)
            //{
            //    transform.Translate(Vector3.up * 4 * Time.deltaTime);
            //    transform.Translate(Vector3.forward * speed * Time.deltaTime);
            //}
            Vector3 temp = new Vector3(0, .7f, 0);
            GetComponent<Rigidbody>().AddForce(temp * 3.5f, ForceMode.Impulse);
        }
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Checkpoint")
        {
            // insert stuff about score/pos
            hitCheckPoint = true;
            gameState.hitCP = true;
            float temp = gameState.difficulty * 2.5f;
            noPathsCrossed = (int)(temp) + 1;
        }

        if(other.name == "EndTrigger")
        {
            if(noPathsCrossed-1 == (int)(gameState.difficulty * 5))
            {
                SceneManager.LoadScene(2);
            }

            noPathsCrossed++;
        }

    }

    void OnApplicationQuit()
    {
        gameState.hitCP = false;
    }

    public void die()
    {
        canvas.SetActive(true);
        movementAllowed = false;
        gameObject.GetComponent<Rigidbody>().useGravity = false;
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        Instantiate(deathPrefab, gameObject.transform.position, Quaternion.identity);

    }

}
