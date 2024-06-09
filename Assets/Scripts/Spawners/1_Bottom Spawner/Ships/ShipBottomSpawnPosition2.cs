
using UnityEngine;

//
// Space Lanes v2024.02.28
//
// v2024.05.16
//

public class ShipBottomSpawnPosition2 : MonoBehaviour
{
    public static ShipBottomSpawnPosition2 bottomSpawner;

    public GameObject[] ships;


    private void Awake()
    {
        bottomSpawner = this;
    }


    // spawn a random orb
    public void SpawnShip()
    {
        switch (SpawnController.spawnController.bottomShipColour)
        {
            case GameController.RED:

                ships[SpawnController.spawnController.bottomShipID].SetActive(true);

                ships[SpawnController.spawnController.bottomShipID] = ships[SpawnController.spawnController.bottomShipID];

                break;

            /*case GameController.ORANGE:

                orangeSquadron[SpawnController.spawnController.bottomShipID].SetActive(true);

                GameController.gameController.orangeSquadron[SpawnController.spawnController.bottomShipID] = orangeSquadron[SpawnController.spawnController.bottomShipID];

                break;

            case GameController.YELLOW:

                yellowSquadron[SpawnController.spawnController.bottomShipID].SetActive(true);

                GameController.gameController.yellowSquadron[SpawnController.spawnController.bottomShipID] = yellowSquadron[SpawnController.spawnController.bottomShipID];

                break;

            case GameController.GREEN:

                greenSquadron[SpawnController.spawnController.bottomShipID].SetActive(true);

                GameController.gameController.greenSquadron[SpawnController.spawnController.bottomShipID] = greenSquadron[SpawnController.spawnController.bottomShipID];

                break;

            case GameController.BLUE:

                blueSquadron[SpawnController.spawnController.bottomShipID].SetActive(true);

                GameController.gameController.blueSquadron[SpawnController.spawnController.bottomShipID] = blueSquadron[SpawnController.spawnController.bottomShipID];

                break;

            case GameController.CYAN:

                cyanSquadron[SpawnController.spawnController.bottomShipID].SetActive(true);

                GameController.gameController.cyanSquadron[SpawnController.spawnController.bottomShipID] = cyanSquadron[SpawnController.spawnController.bottomShipID];

                break;

            case GameController.PURPLE:

                purpleSquadron[SpawnController.spawnController.bottomShipID].SetActive(true);

                GameController.gameController.purpleSquadron[SpawnController.spawnController.bottomShipID] = purpleSquadron[SpawnController.spawnController.bottomShipID];

                break;*/
        }
    }


} // end of class
