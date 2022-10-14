using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemy")]

public class MySO : ScriptableObject
{
   public new string enemyName;

   public float money;
   public float attack;
   public float health;
   public float speed;
   public float range;

   public void Print ()
   {
        Debug.Log(enemyName + " has " + attack + " attack. It has " + health + " health. " + money + " dollars. " + speed + "speed and " + range + "range");
   }

   public void UpdateHealth(float num)
    {
        health += num;
    }
    
    public void UpdateMoney(float num)
    {
        money += num;
    }
}
