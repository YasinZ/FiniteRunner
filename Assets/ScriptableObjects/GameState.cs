using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : ScriptableObject
{
    public int difficulty = 0;
    public int goal = 0;
    public bool hitCP = false;
    public bool dynamicSpeed = false;
    public bool sound = true;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EnableDynamicSpeed()
    {
        dynamicSpeed = !dynamicSpeed;
    }

    public void EnableSound()
    {
        sound = !sound;
    }
}
