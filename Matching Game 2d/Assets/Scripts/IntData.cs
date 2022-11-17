using UnityEngine;

[CreateAssetMenu]

public class IntData : ScriptableObject
{

    public int value;

    public void SetValue(int num)
    {
        value = num;
        Debug.Log("Score is set");
    }

    public void CompareValue(IntData obj)
    {
        Debug.Log("An attempt was made to update the high score between " + value + " and " + obj.value);
        if (value <= obj.value)
        {
            value = obj.value;
            Debug.Log("New High Score is " + value);
        }
    }

    public void SetValue(IntData obj)
    {
        value = obj.value;
        Debug.Log("Score is set to " + value);
    }

    public void UpdateValue(int num)
    {
        value += num;
    }
}
