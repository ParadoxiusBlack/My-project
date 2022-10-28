using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOthers : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);
    }
}
