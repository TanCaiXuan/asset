using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI scoreText;
    [SerializeField] public TextMeshProUGUI highScoreText;
    private int score = 0;
    private int highScore = 0;
    private string highScoreKey = "HighScore";

    void Start()
    {
        highScore = PlayerPrefs.GetInt(highScoreKey, 0);
        highScoreText.text = ((int)highScore).ToString();
    }

    public void IncreaseScore()
    {
        score += 1;
        scoreText.text = ((int)score).ToString();

        // Check if the current score is higher than the high score
        if (score > highScore)
        {
            // Save the new high score to PlayerPrefs
            highScore = score;
            PlayerPrefs.SetInt(highScoreKey, highScore);
            PlayerPrefs.Save(); // Save PlayerPrefs immediately to ensure data persistence
            highScoreText.text = ((int)highScore).ToString();
        }

    }

}



// Update is called once per frame
/*void Update()
{
    if (GameObject.FindGameObjectWithTag("Player") != null)
    {
        score += 1 * Time.deltaTime;
        scoreText.text = ((int)score).ToString();
    }
}*/



/*void UpdateScore()
    {

        scoreText.text = "Score: " + score.ToString();
    }*/