using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject pickupEffect;
    public float multiplier = 1.4f;
    public float duration = 4f;

    void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup(other);
        }
    }
    IEnumerator Pickup(Collider player)
    {
        Debug.Log("Power up obtained");
        Instantiate(pickupEffect, transform.position, transform.rotation);

        PlayerController stats = player.GetComponent<PlayerController>();
        stats.speed *= multiplier;

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(duration);

        stats.speed /= multiplier;

        Destroy(gameObject); 
    }
}
