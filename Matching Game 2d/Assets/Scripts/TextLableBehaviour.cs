using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Globalization;
using UnityEngine.Events;

[RequireComponent(typeof(Text))]

public class TextLableBehaviour : MonoBehaviour
{
    public Text label;
    public UnityEvent startEvent;
    
    // Start is called before the first frame update
    private void Start()
    {
        label = GetComponent<Text>();
        startEvent.Invoke();
    }

    // Update is called once per frame
    public void UpdateLabel(FloatData obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }

    public void UpdateLabel(IntData obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }
}
