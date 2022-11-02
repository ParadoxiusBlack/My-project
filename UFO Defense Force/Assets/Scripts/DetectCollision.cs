using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Destroy(gameObject);//Destoys this game object
        } else if(!(other.CompareTag("Power")) && !(other.CompareTag("UFO")))
        {
            Destroy(other.gameObject);//Destroys other game object
            Destroy(gameObject);//Destoys this game object
        } 
        
    }
}
