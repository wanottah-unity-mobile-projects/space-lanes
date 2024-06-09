
using UnityEngine;

//
// Space Lanes v2024.02.28
//
// v2024.05.16
//

public class ShipRightSpawnPosition3 : MonoBehaviour
{
    public static ShipRightSpawnPosition3 rightSpawner;

    public GameObject[] ships;


    private void Awake()
    {
        rightSpawner = this;
    }


    public void SpawnShip()
    {
        switch (SpawnController.spawnController.rightShipColour)
        {
            case GameController.RED:

                ships[SpawnController.spawnController.rightShipID].SetActive(true);

                ships[SpawnController.spawnController.rightShipID] = ships[SpawnController.spawnController.rightShipID];

                break;

            /*case GameController.ORANGE:

                orangeSquadron[SpawnController.spawnController.rightShipID].SetActive(true);

                GameController.gameController.orangeSquadron[SpawnController.spawnController.rightShipID] = orangeSquadron[SpawnController.spawnController.rightShipID];

                break;

            case GameController.YELLOW:

                yellowSquadron[SpawnController.spawnController.rightShipID].SetActive(true);

                GameController.gameController.yellowSquadron[SpawnController.spawnController.rightShipID] = yellowSquadron[SpawnController.spawnController.rightShipID];

                break;

            case GameController.GREEN:

                greenSquadron[SpawnController.spawnController.rightShipID].SetActive(true);

                GameController.gameController.greenSquadron[SpawnController.spawnController.rightShipID] = greenSquadron[SpawnController.spawnController.rightShipID];

                break;

            case GameController.BLUE:

                blueSquadron[SpawnController.spawnController.rightShipID].SetActive(true);

                GameController.gameController.blueSquadron[SpawnController.spawnController.rightShipID] = blueSquadron[SpawnController.spawnController.rightShipID];

                break;

            case GameController.CYAN:

                cyanSquadron[SpawnController.spawnController.rightShipID].SetActive(true);

                GameController.gameController.cyanSquadron[SpawnController.spawnController.rightShipID] = cyanSquadron[SpawnController.spawnController.rightShipID];

                break;

            case GameController.PURPLE:

                purpleSquadron[SpawnController.spawnController.rightShipID].SetActive(true);

                GameController.gameController.purpleSquadron[SpawnController.spawnController.rightShipID] = purpleSquadron[SpawnController.spawnController.rightShipID];

                break;*/
        }
    }
    

} // end of class
