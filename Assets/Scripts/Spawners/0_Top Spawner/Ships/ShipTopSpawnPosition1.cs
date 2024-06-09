
using UnityEngine;

//
// Space Lanes v2024.02.28
//
// v2024.05.16
//

public class ShipTopSpawnPosition1 : MonoBehaviour
{
    public static ShipTopSpawnPosition1 topSpawner;

    public GameObject[] ships;


    private void Awake()
    {
        topSpawner = this;
    }


    // spawn a random ship
    public void SpawnShip()
    {
        switch (SpawnController.spawnController.topShipColour)
        {
            case GameController.RED:

                ships[SpawnController.spawnController.topShipID].SetActive(true);

                ships[SpawnController.spawnController.topShipID] = ships[SpawnController.spawnController.topShipID];

                break;

            /*case GameController.ORANGE:

                orangeSquadron[SpawnController.spawnController.topShipID].SetActive(true);

                GameController.gameController.orangeSquadron[SpawnController.spawnController.topShipID] = orangeSquadron[SpawnController.spawnController.topShipID];

                break;

            case GameController.YELLOW:

                yellowSquadron[SpawnController.spawnController.topShipID].SetActive(true);

                GameController.gameController.yellowSquadron[SpawnController.spawnController.topShipID] = yellowSquadron[SpawnController.spawnController.topShipID];

                break;

            case GameController.GREEN:

                greenSquadron[SpawnController.spawnController.topShipID].SetActive(true);

                GameController.gameController.greenSquadron[SpawnController.spawnController.topShipID] = greenSquadron[SpawnController.spawnController.topShipID];

                break;

            case GameController.BLUE:

                blueSquadron[SpawnController.spawnController.topShipID].SetActive(true);

                GameController.gameController.blueSquadron[SpawnController.spawnController.topShipID] = blueSquadron[SpawnController.spawnController.topShipID];

                break;

            case GameController.CYAN:

                cyanSquadron[SpawnController.spawnController.topShipID].SetActive(true);

                GameController.gameController.cyanSquadron[SpawnController.spawnController.topShipID] = cyanSquadron[SpawnController.spawnController.topShipID];

                break;

            case GameController.PURPLE:

                purpleSquadron[SpawnController.spawnController.topShipID].SetActive(true);

                GameController.gameController.purpleSquadron[SpawnController.spawnController.topShipID] = purpleSquadron[SpawnController.spawnController.topShipID];

                break;*/
        }
    }
    

} // end of class
