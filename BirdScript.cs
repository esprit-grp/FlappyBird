using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D body;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive=true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        birdIsAlive=true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& birdIsAlive)
        {
            body.velocity = Vector2.up * flapStrength;
        }
    
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.game0ver();
        birdIsAlive = false;
    }
}
