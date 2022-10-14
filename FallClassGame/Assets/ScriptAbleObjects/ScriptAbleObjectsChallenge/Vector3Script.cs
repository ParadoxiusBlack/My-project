using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]

public class Vector3Script : ScriptableObject
{
    public float yPos;
    public float xPos;
    public float zPos;

    public void UpdateYPos(float num)
    {
        yPos += num;
    }

    public void UpdateXPos(float num)
    {
        xPos += num;
    }

    public void UpdateZPos(float num)
    {
        zPos += num;
    }
}
