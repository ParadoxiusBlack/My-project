using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]

public class SpriteColorBehavior : MonoBehaviour
{
    private SpriteRenderer rendererObj;
    // Start is called before the first frame update
    void Start()
    {
        rendererObj = GetComponent<SpriteRenderer>();
    }

    public void ChangeRendererColor (ColorID obj) 
    {
        rendererObj.color = obj.value;  
    }
    
    public void ChangeRendererColor(ColorIDDataList obj)
    {
        rendererObj.color = obj.currentColor.value;
    }
}
