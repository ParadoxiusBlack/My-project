using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpsOutOfBounds : MonoBehaviour
{
    public float topBounds = 100.0f;
    public float lowerBounds = -10.0f;

    void Awake()
    {
        //Time.timeScale = 1;
    }
    void Update()
    {
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBounds)
        {
            Destroy(gameObject);
            //Time.timeScale = 0;
        }
    }
    private void OnCollisionEnter(Collision collision)
{
   Destroy(this.gameObject);
}
}
