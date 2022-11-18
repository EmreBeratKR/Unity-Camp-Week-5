using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed;
    
    
    private GameManager gameManager;


    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    
    private void Update()
    {
        Move();
    }


    private void Move()
    {
        if (gameManager.isGameOver)
        {
            return;
        }
        
        transform.position += Vector3.left * (speed * Time.deltaTime);

        if (transform.position.x < -12f)
        {
            Destroy(gameObject);
        }
    }
}
