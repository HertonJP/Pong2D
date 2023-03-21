using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class GManager : MonoBehaviour
{
    public int Player1Score = 0;
    public int Player2Score = 0;

    public TMP_Text txtPlayer1Score;
    public TMP_Text txtPlayer2Score;

    public static GManager instance;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        txtPlayer1Score.text = Player1Score.ToString();
        txtPlayer2Score.text = Player2Score.ToString();

    }

    public void Score(string wallID)
    {
        if(wallID == "Line L")
        {
            Player2Score = Player2Score + 10;
            txtPlayer2Score.text = Player2Score.ToString();
            ScoreCheck();
        }
        else
        {
            Player1Score = Player1Score + 10;
            txtPlayer1Score.text = Player1Score.ToString();
            ScoreCheck();
        }
    }
    public void ScoreCheck()
    {
        if (Player1Score == 20)
        {
            Debug.Log("player1 win");
            this.gameObject.SendMessage("ChangeScene", "Menu");
        }
        else if (Player2Score == 20)
        {
            Debug.Log("player2 win");
            this.gameObject.SendMessage("ChangeScene", "Menu");
        }
    }

    

}
