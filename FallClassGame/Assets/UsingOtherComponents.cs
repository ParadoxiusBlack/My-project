using UnityEngine;
using System.Collections;

public class UsingOtherComponents : MonoBehaviour
{
    public GameObject otherGameObject;
    
    
    private AnotherScriptOne anotherScriptOne;
    private YetAnotherScript yetAnotherScript;
    private BoxCollider boxCol;
    
    
    void Awake ()
    {
        anotherScriptOne = GetComponent<AnotherScriptOne>();
        yetAnotherScript = otherGameObject.GetComponent<YetAnotherScript>();
        boxCol = otherGameObject.GetComponent<BoxCollider>();
    }
    
    
    void Start ()
    {
        boxCol.size = new Vector3(3,3,3);
        Debug.Log("The player's score is " + anotherScriptOne.playerScore);
        Debug.Log("The player has died " + yetAnotherScript.numberOfPlayerDeaths + " times");
    }
}
