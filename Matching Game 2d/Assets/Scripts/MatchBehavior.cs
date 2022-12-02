using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class MatchBehavior : IDContainerBehavior
{
    
    public UnityEvent matchEvent, noMatchEvent, noMatchDelayedEvent;
    public float waitTime = 0.5f;

    private IEnumerator OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDContainerBehavior>();
        if (tempObj == null) 
            yield break;

        var otherID = tempObj.idObj;
        if (otherID == idObj)
        {
            matchEvent.Invoke();
        }    
        else
        {
            noMatchEvent.Invoke();
            yield return new WaitForSeconds(waitTime);
            noMatchDelayedEvent.Invoke();
        }
    }
}
//Debug.Log(otherID== idObj ? "Matched" : "No Match");