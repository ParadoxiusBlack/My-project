using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 25;
    public float xRange = 30;

    public Transform blaster;
    public GameObject laserBolt;

    // Update is called once per frame
    void Update()
    {
        // Initializes the HorizontalInput to recieve values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");
        //Moves Player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        // Keeps player in bounds
        // Left side wall
        if(transform.position.x < -xRange )
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        // Right side wall
        if(transform.position.x > xRange )
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {   
            //Create laserbot at the blaster transform position maintaining the objects rotation.
            Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation);
        }

    }
    // Delete any object with a trigger that hits the player
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
    }
}
