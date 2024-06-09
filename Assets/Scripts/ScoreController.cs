
using System;
using TMPro;
using UnityEngine;

//
// Space Lanes v2024.02.28
//
// v2024.05.14
//

public class ScoreController : MonoBehaviour
{
    public static ScoreController scoreController;


    public TMP_Text player1Score;

    public TMP_Text highScore;


    private void Awake()
    {
        scoreController = this;
    }


    public void InitialiseScores()
    {
        DisplayPlayer1Score(GameController.gameController.score.ToString());

        DisplayHighScore(GameController.gameController.highScore.ToString());
    }


    public void DisplayPlayer1Score(string scoreText)
    {
        player1Score.text = scoreText;
    }


    public void DisplayHighScore(string scoreText)
    {
        highScore.text = scoreText;
    }


} // end of class
