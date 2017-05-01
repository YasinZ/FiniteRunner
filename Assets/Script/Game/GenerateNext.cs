using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GenerateNext : MonoBehaviour {

    public Transform startLocal;
    public GameObject [] prefab;
    public GameObject prefabCP;
    private GameObject agent;
    public GameState gameState;


    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update () {
        agent = GameObject.FindWithTag("Agent");

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && GameObject.FindWithTag("Player").GetComponent<PlayerMovingController>().noPathsCrossed != gameState.difficulty*2.5f)
        {
            Vector3 pos = new Vector3(startLocal.position.x, startLocal.position.y, startLocal.position.z + 5);
            int randFab = Random.Range(0, 4);

            GameObject g = Instantiate(prefab[randFab], pos, Quaternion.identity);
            agent.GetComponent<MoveTo>().ChangeGoal(g.transform);
            Destroy(gameObject.transform.parent.gameObject, 4);
        }
        else if(other.tag == "Player")
        {
            Vector3 pos = new Vector3(startLocal.position.x, startLocal.position.y, startLocal.position.z + 5);

            GameObject g = Instantiate(prefabCP, pos, Quaternion.identity);
            agent.GetComponent<MoveTo>().ChangeGoal(g.transform);
            Destroy(gameObject.transform.parent.gameObject, 4);
        }
    }


}
