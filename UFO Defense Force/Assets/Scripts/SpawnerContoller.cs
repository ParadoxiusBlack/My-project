using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerContoller : MonoBehaviour
{
    public Transform blaster;
    public GameObject laserBolt;
    public float interval = 3f;
    private float time = 0f;
 
    void Start() {
        time = 0f;
    }
 
    void Update() {
        time += Time.deltaTime;
    while(time >= interval) {
      Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation);
      time -= interval;
    }
            
    }
}

