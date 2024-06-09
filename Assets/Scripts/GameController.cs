
using System.Collections;
using UnityEngine;
using TMPro;

//
// Space Lanes v2024.02.28
//
// v2024.05.16
//

public class GameController : MonoBehaviour
{
    public static GameController gameController;


    public Transform uiMenu;
    public Transform uiGamePlay;
    public Transform uiNewWave;
    public Transform uiPawz;
    public Transform uiGameOver;


    public const int NUMBER_OF_SHIP_COLOURS = 7;

    public const int NUMBER_OF_SHIPS = 4;

    public const int NUMBER_OF_CHILD_SHIPS = 3;


    // ship colours
    public const int RED = 0;
    public const int ORANGE = 1;
    public const int YELLOW = 2;
    public const int GREEN = 3;
    public const int BLUE = 4;
    public const int CYAN = 5;
    public const int PURPLE = 6;


    public float shipSpeed;

    public float stargateSpeed;

    public float redShipSpeed;
    public float orangeShipSpeed;
    public float yellowShipSpeed;
    public float greenShipSpeed;
    public float blueShipSpeed;
    public float cyanShipSpeed;
    public float purpleShipSpeed;

    public float redShipsDocked;
    public float orangeShipsDocked;
    public float yellowShipsDocked;
    public float greenShipsDocked;
    public float blueShipsDocked;
    public float cyanShipsDocked;
    public float purpleShipsDocked;

    public float spawnTimer;

    public int score;

    public int lives;

    public int wave;

    public int highScore;


    public bool inPlay;

    public bool gameOver;

    public bool inAttractMode;


    private void Awake()
    {
        gameController = this;
    }


    void Start()
    {
        CabinetStartUp();
    }


    void Update()
    {
        GameLoop();
    }


    private void CabinetStartUp()
    {
        DeactivateSquadrons();

        score = 0;

        lives = 0;

        wave = 0;

        highScore = 0;

        shipSpeed = 15f;

        stargateSpeed = 20f;

        redShipSpeed = shipSpeed;

        orangeShipSpeed = shipSpeed;

        yellowShipSpeed = shipSpeed;

        greenShipSpeed = shipSpeed;

        blueShipSpeed = shipSpeed;

        cyanShipSpeed = shipSpeed;

        purpleShipSpeed = shipSpeed;

        spawnTimer = 5f;

        ScoreController.scoreController.InitialiseScores();

        LivesController.livesController.InitialiseLives();

        WaveController.waveController.InitialiseWave();

        inPlay = false;

        gameOver = true;

        inAttractMode = true;

        AttractMode();
    }


    private void DeactivateSquadrons()
    {
        ShipController.shipController.DeactivateAllShips();
    }


    private void AttractMode()
    {
        uiMenu.gameObject.SetActive(true);

        SpawnController.spawnController.RunSpawner();
    }


    private IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(1f);

        gameOver = false;

        //canPlay = true;
    }


    private void GameLoop()
    {
        if (inAttractMode)
        {
            AttractMode();
        }


        /*if (gameOver)
        {
            //inPlay = false;

            gameOver = true;

            inAttractMode = true;

            UpdateHighScore();

            ///gameOverText.gameObject.SetActive(true);
        }

        else
        {
            //KeyboardController();
            //StartOnePlayer();

            //
        }*/

        SpawnController.spawnController.RunSpawner();
    }


    public void StartOnePlayer()
    {
        uiMenu.gameObject.SetActive(false);

        if (!inPlay)
        {
            Initialise();

            inPlay = true;
        }

        uiGamePlay.gameObject.SetActive(true);
    }


    private void Initialise()
    {
        DeactivateSquadrons();

        score = 0;

        lives = 3;

        wave = 1;

        ScoreController.scoreController.DisplayPlayer1Score(score.ToString());

        LivesController.livesController.DisplayLives(lives.ToString());

        WaveController.waveController.DisplayWave(wave.ToString());

        //Player1Controller.player1.Initialise();

        ///gameOverText.gameObject.SetActive(false);

        //StartCoroutine(StartDelay());

        gameOver = false;

        inAttractMode = false;
    }


    public void UpdatePlayerScore(int points)
    {
        score += points;

        ScoreController.scoreController.DisplayPlayer1Score(score.ToString());
    }


    private void UpdateHighScore()
    {
        if (score > highScore)
        {
            highScore = score;
        }

        ScoreController.scoreController.DisplayHighScore(highScore.ToString());
    }











    /*
    // stargates
    public GameObject[] redStargate;
    public GameObject[] orangeStargate;
    public GameObject[] yellowStargate;
    public GameObject[] greenStargate;
    public GameObject[] blueStargate;
    public GameObject[] cyanStargate;
    public GameObject[] purpleStargate;

    // ships
    public GameObject[] redSquadron;
    public GameObject[] orangeSquadron;
    public GameObject[] yellowSquadron;
    public GameObject[] greenSquadron;
    public GameObject[] blueSquadron;
    public GameObject[] cyanSquadron;
    public GameObject[] purpleSquadron;


    public const int NUMBER_OF_COLOURS = 7;

    public const int NUMBER_OF_STARGATES = 1;

    public const int NUMBER_OF_SHIPS = 4;


    // ship / stargate colours
    public const int RED = 0;
    public const int ORANGE = 1;
    public const int YELLOW = 2;
    public const int GREEN = 3;
    public const int BLUE = 4;
    public const int CYAN = 5;
    public const int PURPLE = 6;

    // stargate ID
    public const int STARGATE_ID = 0;

    // ship ID's
    public const int SHIP_1_ID = 0;
    public const int SHIP_2_ID = 1;
    public const int SHIP_3_ID = 2;
    public const int SHIP_4_ID = 3;


    public float shipSpeed;
    
    public float stargateSpeed;

    public float redStargateSpeed;
    public float orangeStargateSpeed;
    public float yellowStargateSpeed;
    public float greenStargateSpeed;
    public float blueStargateSpeed;
    public float cyanStargateSpeed;
    public float purpleStargateSpeed;

    public float redShipSpeed;
    public float orangeShipSpeed;
    public float yellowShipSpeed;
    public float greenShipSpeed;
    public float blueShipSpeed;
    public float cyanShipSpeed;
    public float purpleShipSpeed;

    public float redShipsDocked;
    public float orangeShipsDocked;
    public float yellowShipsDocked;
    public float greenShipsDocked;
    public float blueShipsDocked;
    public float cyanShipsDocked;
    public float purpleShipsDocked;

    public float stargateSpawnTimer;

    public float shipSpawnTimer;

    public int player1Score;

    public int lives;

    public int wave;

    public int highScore;


    public bool inPlay;

    public bool canPlay;

    public bool gameOver;

    public bool inAttractMode;


    private void Awake()
    {
        gameController = this;
    }


    void Start()
    {
        CabinetStartUp();
    }


    void Update()
    {
        //GameLoop();
    }


    private void CabinetStartUp()
    {
        redStargate = new GameObject[NUMBER_OF_STARGATES];

        orangeStargate = new GameObject[NUMBER_OF_STARGATES];

        yellowStargate = new GameObject[NUMBER_OF_STARGATES];

        greenStargate = new GameObject[NUMBER_OF_STARGATES];

        blueStargate = new GameObject[NUMBER_OF_STARGATES];

        cyanStargate = new GameObject[NUMBER_OF_STARGATES];

        purpleStargate = new GameObject[NUMBER_OF_STARGATES];


        redSquadron = new GameObject[NUMBER_OF_SHIPS];

        orangeSquadron = new GameObject[NUMBER_OF_SHIPS];

        yellowSquadron = new GameObject[NUMBER_OF_SHIPS];

        greenSquadron = new GameObject[NUMBER_OF_SHIPS];

        blueSquadron = new GameObject[NUMBER_OF_SHIPS];

        cyanSquadron = new GameObject[NUMBER_OF_SHIPS];

        purpleSquadron = new GameObject[NUMBER_OF_SHIPS];


        DeactivateSquadrons();

        player1Score = 0;

        lives = 0;

        wave = 0;

        highScore = 0;

        shipSpeed = 30f;

        stargateSpeed = 20f;

        redStargateSpeed = stargateSpeed;

        orangeStargateSpeed = stargateSpeed;

        yellowStargateSpeed = stargateSpeed;

        greenStargateSpeed = stargateSpeed;

        blueStargateSpeed = stargateSpeed;

        cyanStargateSpeed = stargateSpeed;

        purpleStargateSpeed = stargateSpeed;

        redShipSpeed = shipSpeed;

        orangeShipSpeed = shipSpeed;

        yellowShipSpeed = shipSpeed;

        greenShipSpeed = shipSpeed;

        blueShipSpeed = shipSpeed;

        cyanShipSpeed = shipSpeed;

        purpleShipSpeed = shipSpeed;

        stargateSpawnTimer = 5f;

        shipSpawnTimer = 5f;

        ScoreController.scoreController.InitialiseScores();

        LivesController.livesController.InitialiseLives();

        gameOver = false;

        inPlay = false;

        inAttractMode = true;

        AttractMode();      
    }


    private void DeactivateSquadrons()
    {
        DeactivateShips.deactivateShips.DeactivateAllShips();
    }


    private void AttractMode()
    {
        //uiGameOver.gameObject.SetActive(true);
        //uiMenu.gameObject.SetActive(true);

        SpawnController.spawnController.RunSpawner();

        //KeyboardController();
    }


    private IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(1f);

        gameOver = false;

        canPlay = true;
    }


    private void GameLoop()
    {
        if (inAttractMode)
        {
            AttractMode();
        }


        if (gameOver)
        {
            //inPlay = false;

            gameOver = true;

            inAttractMode = true;

            UpdateHighScore();

            uiGameOver.gameObject.SetActive(true);
        }

        else
        {
            //KeyboardController();
            //StartOnePlayer();

            //SpawnController.spawnController.RunSpawner();
        }
    }


    private void KeyboardController()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            StartOnePlayer();
        }
    }


    private void StartOnePlayer()
    {
        if (!inPlay)
        {
            Initialise();
        }

        //SpawnController.spawnController.RunSpawner();
    }


    private void Initialise()
    {
        //DeactivateAllShips();

        player1Score = 0;

        lives = 3;

        wave = 1;

        ScoreController.scoreController.DisplayPlayer1Score(player1Score.ToString());

        //Player1Controller.player1.Initialise();

        //uiGameOver.gameObject.SetActive(false);

        //StartCoroutine(StartDelay());

        gameOver = false;

        inAttractMode = false;

        inPlay = true;

        //canPlay = true;
    }


    public void UpdatePlayerScore(int points)
    {
        player1Score += points;

        ScoreController.scoreController.DisplayPlayer1Score(player1Score.ToString());
    }


    private void UpdateHighScore()
    {
        if (player1Score > highScore)
        {
            highScore = player1Score;
        }

        ScoreController.scoreController.DisplayHighScore(highScore.ToString());
    }*/


} // end of class
