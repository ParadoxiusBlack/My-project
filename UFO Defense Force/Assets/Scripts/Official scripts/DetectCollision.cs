using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public ScoreManager scoreManager; // store reference to score manager
    
    public int scoreToGive;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); //find ScoreManger gameobject and reference ScoreManager script component
    }

    void OnTriggerEnter(Collider other) // Once the trigger has been entered record collision in the argument variable "other"
    {
        if(other.CompareTag("Player"))
        {
            scoreManager.IncreaseScore(scoreToGive);
            Destroy(gameObject);//Destoys this game object
        } else if(!(other.CompareTag("Power")) && !(other.CompareTag("UFO")))
        {
            scoreManager.IncreaseScore(scoreToGive);
            Destroy(other.gameObject);//Destroys other game object
            Destroy(gameObject);//Destoys this game object
        } 
        
    }
}
