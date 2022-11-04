using UnityEngine;

[CreateAssetMenu]

public class DataValues : ScriptableObject
{
    public float value;
    
    public void SetValue (float num)
    {
        value = num;
    }
    
    public void UpdateValue(float num)
    {
        value += num;
        Debug.Log("You have collected this many powerups: " + value);
    }
}
