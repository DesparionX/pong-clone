using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerWon : MonoBehaviour
{
    public GameObject playerWon;
    public Color player1;
    public Color player2;
    public string whoWon;

    private void OnEnable()
    {
        whoWon = PlayerPrefs.GetString("playerWon");
        Text won = this.playerWon.GetComponent<Text>();
        if (whoWon == "Player1")
        {
            won.text = "Player 1 Won !";
            won.color = player1;
        }
        else if (whoWon == "Player2")
        {
            won.text = "Player 2 Won !";
            won.color = player2;
        }
        else
        {
            won.text = "Smth wrong";
        }
    }
}
