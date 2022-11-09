using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //Text Mesh pro namespace added to access the unity librarys for UI

public class ScoreManager : MonoBehaviour
{
    public int score; //Keeping score value
    public TextMeshProUGUI scoreText; // Visual text element to be modified

    public void IncreaseScore(int amount) // score by predetermined amount
    {
        score += amount;
        UpdateScoreText();
    }
    
    public void DecreaseScore(int amount) //decreases score by predetermined amount
    {
        score -= amount;
        UpdateScoreText();
    }

    public void UpdateScoreText() //Updates the value in HUD UI
    {
        scoreText.text = "Score: "+ score;
    }
}
