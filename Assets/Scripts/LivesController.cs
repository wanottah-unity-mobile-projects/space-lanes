
using System;
using TMPro;
using UnityEngine;

//
// Space Lanes v2024.02.28
//
// v2024.05.14
//

public class LivesController : MonoBehaviour
{
    public static LivesController livesController;


    public TMP_Text lives;


    private void Awake()
    {
        livesController = this;
    }


    public void InitialiseLives()
    {
        DisplayLives(GameController.gameController.lives.ToString());
    }


    public void DisplayLives(string livesText)
    {
        lives.text = livesText;
    }



} // end of class
