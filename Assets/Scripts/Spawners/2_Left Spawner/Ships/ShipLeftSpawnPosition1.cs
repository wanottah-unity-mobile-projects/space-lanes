
using UnityEngine;

//
// Space Lanes v2024.02.28
//
// v2024.05.16
//

public class ShipLeftSpawnPosition1 : MonoBehaviour
{
    public static ShipLeftSpawnPosition1 leftSpawner;

    public GameObject[] ships;


    private void Awake()
    {
        leftSpawner = this;
    }


    public void SpawnShip()
    {
        switch (SpawnController.spawnController.leftShipColour)
        {
            case GameController.RED:

                ships[SpawnController.spawnController.leftShipID].SetActive(true);

                ships[SpawnController.spawnController.leftShipID] = ships[SpawnController.spawnController.leftShipID];

                break;

            /*case GameController.ORANGE:

                orangeSquadron[SpawnController.spawnController.leftShipID].SetActive(true);

                GameController.gameController.orangeSquadron[SpawnController.spawnController.leftShipID] = orangeSquadron[SpawnController.spawnController.leftShipID];

                break;

            case GameController.YELLOW:

                yellowSquadron[SpawnController.spawnController.leftShipID].SetActive(true);

                GameController.gameController.yellowSquadron[SpawnController.spawnController.leftShipID] = yellowSquadron[SpawnController.spawnController.leftShipID];

                break;

            case GameController.GREEN:

                greenSquadron[SpawnController.spawnController.leftShipID].SetActive(true);

                GameController.gameController.greenSquadron[SpawnController.spawnController.leftShipID] = greenSquadron[SpawnController.spawnController.leftShipID];

                break;

            case GameController.BLUE:

                blueSquadron[SpawnController.spawnController.leftShipID].SetActive(true);

                GameController.gameController.blueSquadron[SpawnController.spawnController.leftShipID] = blueSquadron[SpawnController.spawnController.leftShipID];

                break;

            case GameController.CYAN:

                cyanSquadron[SpawnController.spawnController.leftShipID].SetActive(true);

                GameController.gameController.cyanSquadron[SpawnController.spawnController.leftShipID] = cyanSquadron[SpawnController.spawnController.leftShipID];

                break;

            case GameController.PURPLE:

                purpleSquadron[SpawnController.spawnController.leftShipID].SetActive(true);

                GameController.gameController.purpleSquadron[SpawnController.spawnController.leftShipID] = purpleSquadron[SpawnController.spawnController.leftShipID];

                break;*/
        }
    }
   

} // end of class
