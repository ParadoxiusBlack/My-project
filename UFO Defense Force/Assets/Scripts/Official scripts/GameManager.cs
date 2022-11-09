using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    private GameObject gameOverText;

    void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver)
        {
            EndGame(); // starts EndGame method
        }
        else    
            gameOverText.gameObject.SetActive(false); //Keeps game over text hidden
    }

    public void EndGame()
    {
        gameOverText.gameObject.SetActive(true); //shows the game over text
        Time.timeScale = 0; //freezes the game  
    }
}
