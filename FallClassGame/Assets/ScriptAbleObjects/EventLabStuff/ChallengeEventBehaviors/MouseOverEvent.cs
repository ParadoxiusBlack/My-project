// This second example changes the GameObject's color to red when the mouse hovers over it
// Ensure the GameObject has a MeshRenderer

using UnityEngine;

public class MouseOverEvent : MonoBehaviour
{
    
    Color m_MouseOverColor = Color.yellow;

    //This stores the GameObject’s original color
    Color m_OriginalColor;

    MeshRenderer m_Renderer;

    void Start()
    {
        m_Renderer = GetComponent<MeshRenderer>();
        m_OriginalColor = m_Renderer.material.color;
    }

    void OnMouseOver()
    {
        m_Renderer.material.color = m_MouseOverColor;
    }

    void OnMouseExit()
    {
        m_Renderer.material.color = m_OriginalColor;
    }
}
