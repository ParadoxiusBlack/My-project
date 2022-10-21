using UnityEngine;
using System.Collections;

public class MouseDragEvent : MonoBehaviour
{
    public Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void OnMouseDrag()
    {
        rend.material.color -= Color.white * Time.deltaTime;
    }
}
