using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    
    public float topBounds = 30.0f;
    public float lowerBounds = -10.0f;
    public float ceilingFloor = 5.0f;
    public GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); // reference gamemanager script
    }

    void Update()
    {
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBounds)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
            gameManager.isGameOver = true;
        }
        else if(transform.position.y > ceilingFloor)
        {
            Destroy(gameObject);
            Debug.Log("Extermination Field Activated");
        }
        else if(transform.position.y < -ceilingFloor)
        {
            Destroy(gameObject);
            Debug.Log("Extermination Field Activated");
        }
    }
}
