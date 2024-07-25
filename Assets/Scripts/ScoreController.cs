using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    private int scorePlayer1 = 0;
    private int scorePlayer2 = 0;
    public string playerWon;

    public GameObject scoreTextPlayer1;
    public GameObject scoreTextPlayer2;

    public int goalToWin;
    void Update()
    {
        if (this.scorePlayer1 >= this.goalToWin || this.scorePlayer2 >= this.goalToWin)
        {
            if (this.scorePlayer1 >= this.goalToWin)
                playerWon = "Player1";
            if (this.scorePlayer2 >= this.goalToWin)
                playerWon = "Player2";
            PlayerPrefs.SetString("playerWon", playerWon);
            SceneManager.LoadScene("GameOver");
            
        }
    }
    private void OnDisable()
    {
        PlayerPrefs.SetString("playerWon", playerWon);
    }
    private void FixedUpdate()
    {
        Text uiScoreP1 = this.scoreTextPlayer1.GetComponent<Text>();
        uiScoreP1.text = this.scorePlayer1.ToString();

        Text uiScoreP2 = this.scoreTextPlayer2.GetComponent<Text>();
        uiScoreP2.text = this.scorePlayer2.ToString();
    }
    public void GoalPOne()
    {
        this.scorePlayer1++;
    }
    public void GoalPTwo()
    {
        this.scorePlayer2++;
    }
}
