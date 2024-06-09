
using System;
using TMPro;
using UnityEngine;

//
// Space Lanes v2024.02.28
//
// v2024.05.14
//

public class WaveController : MonoBehaviour
{
    public static WaveController waveController;


    public TMP_Text wave;

    public TMP_Text newWave;

    public Transform newWaveText;


    private void Awake()
    {
        waveController = this;
    }


    public void InitialiseWave()
    {
        DisplayWave(GameController.gameController.wave.ToString());
    }


    public void DisplayWave(string wave)
    {
        this.wave.text = wave;
    }


    public void DisplayNewWave(string wave)
    {
        newWave.text = wave;
    }



} // end of class
