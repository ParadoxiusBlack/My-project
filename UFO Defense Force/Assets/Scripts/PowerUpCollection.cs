using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpCollection : MonoBehaviour
{
    public float power;
    public void OnTriggerEnter()
    {
        power = power + 1;
        print("Power Up Collected" );
        print("Your power is now " + power);
    }
}
