
using System.Collections;
using UnityEngine;

//
// Space Lanes v2024.02.28
//
// v2024.05.16
//

public class ShipController : MonoBehaviour
{
    public static ShipController shipController;


    public GameObject[] ships;



    private void Awake()
    {
        shipController = this;
    }



    public void DeactivateAllStargates()
    {
        //for (int stargateColour = 0; stargateColour < GameController.NUMBER_OF_SHIP_COLOURS; stargateColour++ )
        //{

        //}

        int stargate = 0;

        /*StargateTopSpawnPosition0.topSpawner.redStargate[stargate].SetActive(false);
        StargateTopSpawnPosition0.topSpawner.orangeStargate[stargate].SetActive(false);
        StargateTopSpawnPosition0.topSpawner.yellowStargate[stargate].SetActive(false);
        StargateTopSpawnPosition0.topSpawner.greenStargate[stargate].SetActive(false);
        StargateTopSpawnPosition0.topSpawner.blueStargate[stargate].SetActive(false);
        StargateTopSpawnPosition0.topSpawner.cyanStargate[stargate].SetActive(false);
        StargateTopSpawnPosition0.topSpawner.purpleStargate[stargate].SetActive(false);

        StargateTopSpawnPosition1.topSpawner.redStargate[stargate].SetActive(false);
        StargateTopSpawnPosition1.topSpawner.orangeStargate[stargate].SetActive(false);
        StargateTopSpawnPosition1.topSpawner.yellowStargate[stargate].SetActive(false);
        StargateTopSpawnPosition1.topSpawner.greenStargate[stargate].SetActive(false);
        StargateTopSpawnPosition1.topSpawner.blueStargate[stargate].SetActive(false);
        StargateTopSpawnPosition1.topSpawner.cyanStargate[stargate].SetActive(false);
        StargateTopSpawnPosition1.topSpawner.purpleStargate[stargate].SetActive(false);

        StargateTopSpawnPosition2.topSpawner.redStargate[stargate].SetActive(false);
        StargateTopSpawnPosition2.topSpawner.orangeStargate[stargate].SetActive(false);
        StargateTopSpawnPosition2.topSpawner.yellowStargate[stargate].SetActive(false);
        StargateTopSpawnPosition2.topSpawner.greenStargate[stargate].SetActive(false);
        StargateTopSpawnPosition2.topSpawner.blueStargate[stargate].SetActive(false);
        StargateTopSpawnPosition2.topSpawner.cyanStargate[stargate].SetActive(false);
        StargateTopSpawnPosition2.topSpawner.purpleStargate[stargate].SetActive(false);

        StargateTopSpawnPosition3.topSpawner.redStargate[stargate].SetActive(false);
        StargateTopSpawnPosition3.topSpawner.orangeStargate[stargate].SetActive(false);
        StargateTopSpawnPosition3.topSpawner.yellowStargate[stargate].SetActive(false);
        StargateTopSpawnPosition3.topSpawner.greenStargate[stargate].SetActive(false);
        StargateTopSpawnPosition3.topSpawner.blueStargate[stargate].SetActive(false);
        StargateTopSpawnPosition3.topSpawner.cyanStargate[stargate].SetActive(false);
        StargateTopSpawnPosition3.topSpawner.purpleStargate[stargate].SetActive(false);

        StargateBottomSpawnPosition0.bottomSpawner.redStargate[stargate].SetActive(false);
        StargateBottomSpawnPosition0.bottomSpawner.orangeStargate[stargate].SetActive(false);
        StargateBottomSpawnPosition0.bottomSpawner.yellowStargate[stargate].SetActive(false);
        StargateBottomSpawnPosition0.bottomSpawner.greenStargate[stargate].SetActive(false);
        StargateBottomSpawnPosition0.bottomSpawner.blueStargate[stargate].SetActive(false);
        StargateBottomSpawnPosition0.bottomSpawner.cyanStargate[stargate].SetActive(false);
        StargateBottomSpawnPosition0.bottomSpawner.purpleStargate[stargate].SetActive(false);

        StargateBottomSpawnPosition1.bottomSpawner.redStargate[stargate].SetActive(false);
        StargateBottomSpawnPosition1.bottomSpawner.orangeStargate[stargate].SetActive(false);
        StargateBottomSpawnPosition1.bottomSpawner.yellowStargate[stargate].SetActive(false);
        StargateBottomSpawnPosition1.bottomSpawner.greenStargate[stargate].SetActive(false);
        StargateBottomSpawnPosition1.bottomSpawner.blueStargate[stargate].SetActive(false);
        StargateBottomSpawnPosition1.bottomSpawner.cyanStargate[stargate].SetActive(false);
        StargateBottomSpawnPosition1.bottomSpawner.purpleStargate[stargate].SetActive(false);

        StargateBottomSpawnPosition2.bottomSpawner.redStargate[stargate].SetActive(false);
        StargateBottomSpawnPosition2.bottomSpawner.orangeStargate[stargate].SetActive(false);
        StargateBottomSpawnPosition2.bottomSpawner.yellowStargate[stargate].SetActive(false);
        StargateBottomSpawnPosition2.bottomSpawner.greenStargate[stargate].SetActive(false);
        StargateBottomSpawnPosition2.bottomSpawner.blueStargate[stargate].SetActive(false);
        StargateBottomSpawnPosition2.bottomSpawner.cyanStargate[stargate].SetActive(false);
        StargateBottomSpawnPosition2.bottomSpawner.purpleStargate[stargate].SetActive(false);

        StargateBottomSpawnPosition3.bottomSpawner.redStargate[stargate].SetActive(false);
        StargateBottomSpawnPosition3.bottomSpawner.orangeStargate[stargate].SetActive(false);
        StargateBottomSpawnPosition3.bottomSpawner.yellowStargate[stargate].SetActive(false);
        StargateBottomSpawnPosition3.bottomSpawner.greenStargate[stargate].SetActive(false);
        StargateBottomSpawnPosition3.bottomSpawner.blueStargate[stargate].SetActive(false);
        StargateBottomSpawnPosition3.bottomSpawner.cyanStargate[stargate].SetActive(false);
        StargateBottomSpawnPosition3.bottomSpawner.purpleStargate[stargate].SetActive(false);

        StargateLeftSpawnPosition0.leftSpawner.redStargate[stargate].SetActive(false);
        StargateLeftSpawnPosition0.leftSpawner.orangeStargate[stargate].SetActive(false);
        StargateLeftSpawnPosition0.leftSpawner.yellowStargate[stargate].SetActive(false);
        StargateLeftSpawnPosition0.leftSpawner.greenStargate[stargate].SetActive(false);
        StargateLeftSpawnPosition0.leftSpawner.blueStargate[stargate].SetActive(false);
        StargateLeftSpawnPosition0.leftSpawner.cyanStargate[stargate].SetActive(false);
        StargateLeftSpawnPosition0.leftSpawner.purpleStargate[stargate].SetActive(false);

        StargateLeftSpawnPosition1.leftSpawner.redStargate[stargate].SetActive(false);
        StargateLeftSpawnPosition1.leftSpawner.orangeStargate[stargate].SetActive(false);
        StargateLeftSpawnPosition1.leftSpawner.yellowStargate[stargate].SetActive(false);
        StargateLeftSpawnPosition1.leftSpawner.greenStargate[stargate].SetActive(false);
        StargateLeftSpawnPosition1.leftSpawner.blueStargate[stargate].SetActive(false);
        StargateLeftSpawnPosition1.leftSpawner.cyanStargate[stargate].SetActive(false);
        StargateLeftSpawnPosition1.leftSpawner.purpleStargate[stargate].SetActive(false);

        StargateLeftSpawnPosition2.leftSpawner.redStargate[stargate].SetActive(false);
        StargateLeftSpawnPosition2.leftSpawner.orangeStargate[stargate].SetActive(false);
        StargateLeftSpawnPosition2.leftSpawner.yellowStargate[stargate].SetActive(false);
        StargateLeftSpawnPosition2.leftSpawner.greenStargate[stargate].SetActive(false);
        StargateLeftSpawnPosition2.leftSpawner.blueStargate[stargate].SetActive(false);
        StargateLeftSpawnPosition2.leftSpawner.cyanStargate[stargate].SetActive(false);
        StargateLeftSpawnPosition2.leftSpawner.purpleStargate[stargate].SetActive(false);

        StargateLeftSpawnPosition3.leftSpawner.redStargate[stargate].SetActive(false);
        StargateLeftSpawnPosition3.leftSpawner.orangeStargate[stargate].SetActive(false);
        StargateLeftSpawnPosition3.leftSpawner.yellowStargate[stargate].SetActive(false);
        StargateLeftSpawnPosition3.leftSpawner.greenStargate[stargate].SetActive(false);
        StargateLeftSpawnPosition3.leftSpawner.blueStargate[stargate].SetActive(false);
        StargateLeftSpawnPosition3.leftSpawner.cyanStargate[stargate].SetActive(false);
        StargateLeftSpawnPosition3.leftSpawner.purpleStargate[stargate].SetActive(false);

        StargateRightSpawnPosition0.rightSpawner.redStargate[stargate].SetActive(false);
        StargateRightSpawnPosition0.rightSpawner.orangeStargate[stargate].SetActive(false);
        StargateRightSpawnPosition0.rightSpawner.yellowStargate[stargate].SetActive(false);
        StargateRightSpawnPosition0.rightSpawner.greenStargate[stargate].SetActive(false);
        StargateRightSpawnPosition0.rightSpawner.blueStargate[stargate].SetActive(false);
        StargateRightSpawnPosition0.rightSpawner.cyanStargate[stargate].SetActive(false);
        StargateRightSpawnPosition0.rightSpawner.purpleStargate[stargate].SetActive(false);

        StargateRightSpawnPosition1.rightSpawner.redStargate[stargate].SetActive(false);
        StargateRightSpawnPosition1.rightSpawner.orangeStargate[stargate].SetActive(false);
        StargateRightSpawnPosition1.rightSpawner.yellowStargate[stargate].SetActive(false);
        StargateRightSpawnPosition1.rightSpawner.greenStargate[stargate].SetActive(false);
        StargateRightSpawnPosition1.rightSpawner.blueStargate[stargate].SetActive(false);
        StargateRightSpawnPosition1.rightSpawner.cyanStargate[stargate].SetActive(false);
        StargateRightSpawnPosition1.rightSpawner.purpleStargate[stargate].SetActive(false);

        StargateRightSpawnPosition2.rightSpawner.redStargate[stargate].SetActive(false);
        StargateRightSpawnPosition2.rightSpawner.orangeStargate[stargate].SetActive(false);
        StargateRightSpawnPosition2.rightSpawner.yellowStargate[stargate].SetActive(false);
        StargateRightSpawnPosition2.rightSpawner.greenStargate[stargate].SetActive(false);
        StargateRightSpawnPosition2.rightSpawner.blueStargate[stargate].SetActive(false);
        StargateRightSpawnPosition2.rightSpawner.cyanStargate[stargate].SetActive(false);
        StargateRightSpawnPosition2.rightSpawner.purpleStargate[stargate].SetActive(false);

        StargateRightSpawnPosition3.rightSpawner.redStargate[stargate].SetActive(false);
        StargateRightSpawnPosition3.rightSpawner.orangeStargate[stargate].SetActive(false);
        StargateRightSpawnPosition3.rightSpawner.yellowStargate[stargate].SetActive(false);
        StargateRightSpawnPosition3.rightSpawner.greenStargate[stargate].SetActive(false);
        StargateRightSpawnPosition3.rightSpawner.blueStargate[stargate].SetActive(false);
        StargateRightSpawnPosition3.rightSpawner.cyanStargate[stargate].SetActive(false);
        StargateRightSpawnPosition3.rightSpawner.purpleStargate[stargate].SetActive(false);*/
    }


    public void DeactivateAllShips()
    {
        for (int ship = 0; ship < GameController.NUMBER_OF_SHIP_COLOURS; ship++)
        {
            // red squadron
            ShipTopSpawnPosition0.topSpawner.ships[ship].SetActive(false);
            ShipTopSpawnPosition1.topSpawner.ships[ship].SetActive(false);
            ShipTopSpawnPosition2.topSpawner.ships[ship].SetActive(false);
            ShipTopSpawnPosition3.topSpawner.ships[ship].SetActive(false);

            ShipBottomSpawnPosition0.bottomSpawner.ships[ship].SetActive(false);
            ShipBottomSpawnPosition1.bottomSpawner.ships[ship].SetActive(false);
            ShipBottomSpawnPosition2.bottomSpawner.ships[ship].SetActive(false);
            ShipBottomSpawnPosition3.bottomSpawner.ships[ship].SetActive(false);

            ShipLeftSpawnPosition0.leftSpawner.ships[ship].SetActive(false);
            ShipLeftSpawnPosition1.leftSpawner.ships[ship].SetActive(false);
            ShipLeftSpawnPosition2.leftSpawner.ships[ship].SetActive(false);
            ShipLeftSpawnPosition3.leftSpawner.ships[ship].SetActive(false);

            ShipRightSpawnPosition0.rightSpawner.ships[ship].SetActive(false);
            ShipRightSpawnPosition1.rightSpawner.ships[ship].SetActive(false);
            ShipRightSpawnPosition2.rightSpawner.ships[ship].SetActive(false);
            ShipRightSpawnPosition3.rightSpawner.ships[ship].SetActive(false);

            // orange squadron
            /*ShipTopSpawnPosition0.topSpawner.orangeSquadron[ship].SetActive(false);
            ShipTopSpawnPosition1.topSpawner.orangeSquadron[ship].SetActive(false);
            ShipTopSpawnPosition2.topSpawner.orangeSquadron[ship].SetActive(false);
            ShipTopSpawnPosition3.topSpawner.orangeSquadron[ship].SetActive(false);

            ShipBottomSpawnPosition0.bottomSpawner.orangeSquadron[ship].SetActive(false);
            ShipBottomSpawnPosition1.bottomSpawner.orangeSquadron[ship].SetActive(false);
            ShipBottomSpawnPosition2.bottomSpawner.orangeSquadron[ship].SetActive(false);
            ShipBottomSpawnPosition3.bottomSpawner.orangeSquadron[ship].SetActive(false);

            ShipLeftSpawnPosition0.leftSpawner.orangeSquadron[ship].SetActive(false);
            ShipLeftSpawnPosition1.leftSpawner.orangeSquadron[ship].SetActive(false);
            ShipLeftSpawnPosition2.leftSpawner.orangeSquadron[ship].SetActive(false);
            ShipLeftSpawnPosition3.leftSpawner.orangeSquadron[ship].SetActive(false);

            ShipRightSpawnPosition0.rightSpawner.orangeSquadron[ship].SetActive(false);
            ShipRightSpawnPosition1.rightSpawner.orangeSquadron[ship].SetActive(false);
            ShipRightSpawnPosition2.rightSpawner.orangeSquadron[ship].SetActive(false);
            ShipRightSpawnPosition3.rightSpawner.orangeSquadron[ship].SetActive(false);

            // yellow squadron
            ShipTopSpawnPosition0.topSpawner.yellowSquadron[ship].SetActive(false);
            ShipTopSpawnPosition1.topSpawner.yellowSquadron[ship].SetActive(false);
            ShipTopSpawnPosition2.topSpawner.yellowSquadron[ship].SetActive(false);
            ShipTopSpawnPosition3.topSpawner.yellowSquadron[ship].SetActive(false);

            ShipBottomSpawnPosition0.bottomSpawner.yellowSquadron[ship].SetActive(false);
            ShipBottomSpawnPosition1.bottomSpawner.yellowSquadron[ship].SetActive(false);
            ShipBottomSpawnPosition2.bottomSpawner.yellowSquadron[ship].SetActive(false);
            ShipBottomSpawnPosition3.bottomSpawner.yellowSquadron[ship].SetActive(false);

            ShipLeftSpawnPosition0.leftSpawner.yellowSquadron[ship].SetActive(false);
            ShipLeftSpawnPosition1.leftSpawner.yellowSquadron[ship].SetActive(false);
            ShipLeftSpawnPosition2.leftSpawner.yellowSquadron[ship].SetActive(false);
            ShipLeftSpawnPosition3.leftSpawner.yellowSquadron[ship].SetActive(false);

            ShipRightSpawnPosition0.rightSpawner.yellowSquadron[ship].SetActive(false);
            ShipRightSpawnPosition1.rightSpawner.yellowSquadron[ship].SetActive(false);
            ShipRightSpawnPosition2.rightSpawner.yellowSquadron[ship].SetActive(false);
            ShipRightSpawnPosition3.rightSpawner.yellowSquadron[ship].SetActive(false);

            // green squadron
            ShipTopSpawnPosition0.topSpawner.greenSquadron[ship].SetActive(false);
            ShipTopSpawnPosition1.topSpawner.greenSquadron[ship].SetActive(false);
            ShipTopSpawnPosition2.topSpawner.greenSquadron[ship].SetActive(false);
            ShipTopSpawnPosition3.topSpawner.greenSquadron[ship].SetActive(false);

            ShipBottomSpawnPosition0.bottomSpawner.greenSquadron[ship].SetActive(false);
            ShipBottomSpawnPosition1.bottomSpawner.greenSquadron[ship].SetActive(false);
            ShipBottomSpawnPosition2.bottomSpawner.greenSquadron[ship].SetActive(false);
            ShipBottomSpawnPosition3.bottomSpawner.greenSquadron[ship].SetActive(false);

            ShipLeftSpawnPosition0.leftSpawner.greenSquadron[ship].SetActive(false);
            ShipLeftSpawnPosition1.leftSpawner.greenSquadron[ship].SetActive(false);
            ShipLeftSpawnPosition2.leftSpawner.greenSquadron[ship].SetActive(false);
            ShipLeftSpawnPosition3.leftSpawner.greenSquadron[ship].SetActive(false);

            ShipRightSpawnPosition0.rightSpawner.greenSquadron[ship].SetActive(false);
            ShipRightSpawnPosition1.rightSpawner.greenSquadron[ship].SetActive(false);
            ShipRightSpawnPosition2.rightSpawner.greenSquadron[ship].SetActive(false);
            ShipRightSpawnPosition3.rightSpawner.greenSquadron[ship].SetActive(false);

            // blue squadron
            ShipTopSpawnPosition0.topSpawner.blueSquadron[ship].SetActive(false);
            ShipTopSpawnPosition1.topSpawner.blueSquadron[ship].SetActive(false);
            ShipTopSpawnPosition2.topSpawner.blueSquadron[ship].SetActive(false);
            ShipTopSpawnPosition3.topSpawner.blueSquadron[ship].SetActive(false);

            ShipBottomSpawnPosition0.bottomSpawner.blueSquadron[ship].SetActive(false);
            ShipBottomSpawnPosition1.bottomSpawner.blueSquadron[ship].SetActive(false);
            ShipBottomSpawnPosition2.bottomSpawner.blueSquadron[ship].SetActive(false);
            ShipBottomSpawnPosition3.bottomSpawner.blueSquadron[ship].SetActive(false);

            ShipLeftSpawnPosition0.leftSpawner.blueSquadron[ship].SetActive(false);
            ShipLeftSpawnPosition1.leftSpawner.blueSquadron[ship].SetActive(false);
            ShipLeftSpawnPosition2.leftSpawner.blueSquadron[ship].SetActive(false);
            ShipLeftSpawnPosition3.leftSpawner.blueSquadron[ship].SetActive(false);

            ShipRightSpawnPosition0.rightSpawner.blueSquadron[ship].SetActive(false);
            ShipRightSpawnPosition1.rightSpawner.blueSquadron[ship].SetActive(false);
            ShipRightSpawnPosition2.rightSpawner.blueSquadron[ship].SetActive(false);
            ShipRightSpawnPosition3.rightSpawner.blueSquadron[ship].SetActive(false);

            // cyan squadron
            ShipTopSpawnPosition0.topSpawner.cyanSquadron[ship].SetActive(false);
            ShipTopSpawnPosition1.topSpawner.cyanSquadron[ship].SetActive(false);
            ShipTopSpawnPosition2.topSpawner.cyanSquadron[ship].SetActive(false);
            ShipTopSpawnPosition3.topSpawner.cyanSquadron[ship].SetActive(false);

            ShipBottomSpawnPosition0.bottomSpawner.cyanSquadron[ship].SetActive(false);
            ShipBottomSpawnPosition1.bottomSpawner.cyanSquadron[ship].SetActive(false);
            ShipBottomSpawnPosition2.bottomSpawner.cyanSquadron[ship].SetActive(false);
            ShipBottomSpawnPosition3.bottomSpawner.cyanSquadron[ship].SetActive(false);

            ShipLeftSpawnPosition0.leftSpawner.cyanSquadron[ship].SetActive(false);
            ShipLeftSpawnPosition1.leftSpawner.cyanSquadron[ship].SetActive(false);
            ShipLeftSpawnPosition2.leftSpawner.cyanSquadron[ship].SetActive(false);
            ShipLeftSpawnPosition3.leftSpawner.cyanSquadron[ship].SetActive(false);

            ShipRightSpawnPosition0.rightSpawner.cyanSquadron[ship].SetActive(false);
            ShipRightSpawnPosition1.rightSpawner.cyanSquadron[ship].SetActive(false);
            ShipRightSpawnPosition2.rightSpawner.cyanSquadron[ship].SetActive(false);
            ShipRightSpawnPosition3.rightSpawner.cyanSquadron[ship].SetActive(false);

            // purple squadron
            ShipTopSpawnPosition0.topSpawner.purpleSquadron[ship].SetActive(false);
            ShipTopSpawnPosition1.topSpawner.purpleSquadron[ship].SetActive(false);
            ShipTopSpawnPosition2.topSpawner.purpleSquadron[ship].SetActive(false);
            ShipTopSpawnPosition3.topSpawner.purpleSquadron[ship].SetActive(false);

            ShipBottomSpawnPosition0.bottomSpawner.purpleSquadron[ship].SetActive(false);
            ShipBottomSpawnPosition1.bottomSpawner.purpleSquadron[ship].SetActive(false);
            ShipBottomSpawnPosition2.bottomSpawner.purpleSquadron[ship].SetActive(false);
            ShipBottomSpawnPosition3.bottomSpawner.purpleSquadron[ship].SetActive(false);

            ShipLeftSpawnPosition0.leftSpawner.purpleSquadron[ship].SetActive(false);
            ShipLeftSpawnPosition1.leftSpawner.purpleSquadron[ship].SetActive(false);
            ShipLeftSpawnPosition2.leftSpawner.purpleSquadron[ship].SetActive(false);
            ShipLeftSpawnPosition3.leftSpawner.purpleSquadron[ship].SetActive(false);

            ShipRightSpawnPosition0.rightSpawner.purpleSquadron[ship].SetActive(false);
            ShipRightSpawnPosition1.rightSpawner.purpleSquadron[ship].SetActive(false);
            ShipRightSpawnPosition2.rightSpawner.purpleSquadron[ship].SetActive(false);
            ShipRightSpawnPosition3.rightSpawner.purpleSquadron[ship].SetActive(false);*/
        }


        for (int ship = 0; ship < GameController.NUMBER_OF_SHIP_COLOURS; ship++) // squadron.Length; ship++)
        {
            // red squadron
            ShipTopSpawnPosition0.topSpawner.ships[ship].transform.position = ShipTopSpawnPosition0.topSpawner.transform.position;
            ShipTopSpawnPosition1.topSpawner.ships[ship].transform.position = ShipTopSpawnPosition1.topSpawner.transform.position;
            ShipTopSpawnPosition2.topSpawner.ships[ship].transform.position = ShipTopSpawnPosition2.topSpawner.transform.position;
            ShipTopSpawnPosition3.topSpawner.ships[ship].transform.position = ShipTopSpawnPosition3.topSpawner.transform.position;

            ShipBottomSpawnPosition0.bottomSpawner.ships[ship].transform.position = ShipBottomSpawnPosition0.bottomSpawner.transform.position;
            ShipBottomSpawnPosition1.bottomSpawner.ships[ship].transform.position = ShipBottomSpawnPosition1.bottomSpawner.transform.position;
            ShipBottomSpawnPosition2.bottomSpawner.ships[ship].transform.position = ShipBottomSpawnPosition2.bottomSpawner.transform.position;
            ShipBottomSpawnPosition3.bottomSpawner.ships[ship].transform.position = ShipBottomSpawnPosition3.bottomSpawner.transform.position;

            ShipLeftSpawnPosition0.leftSpawner.ships[ship].transform.position = ShipLeftSpawnPosition0.leftSpawner.transform.position;
            ShipLeftSpawnPosition1.leftSpawner.ships[ship].transform.position = ShipLeftSpawnPosition1.leftSpawner.transform.position;
            ShipLeftSpawnPosition2.leftSpawner.ships[ship].transform.position = ShipLeftSpawnPosition2.leftSpawner.transform.position;
            ShipLeftSpawnPosition3.leftSpawner.ships[ship].transform.position = ShipLeftSpawnPosition3.leftSpawner.transform.position;

            ShipRightSpawnPosition0.rightSpawner.ships[ship].transform.position = ShipRightSpawnPosition0.rightSpawner.transform.position;
            ShipRightSpawnPosition1.rightSpawner.ships[ship].transform.position = ShipRightSpawnPosition1.rightSpawner.transform.position;
            ShipRightSpawnPosition2.rightSpawner.ships[ship].transform.position = ShipRightSpawnPosition2.rightSpawner.transform.position;
            ShipRightSpawnPosition3.rightSpawner.ships[ship].transform.position = ShipRightSpawnPosition3.rightSpawner.transform.position;

            // orange squadron
            /*ShipTopSpawnPosition0.topSpawner.orangeSquadron[ship].transform.position = ShipTopSpawnPosition0.topSpawner.transform.position;
            ShipTopSpawnPosition1.topSpawner.orangeSquadron[ship].transform.position = ShipTopSpawnPosition1.topSpawner.transform.position;
            ShipTopSpawnPosition2.topSpawner.orangeSquadron[ship].transform.position = ShipTopSpawnPosition2.topSpawner.transform.position;
            ShipTopSpawnPosition3.topSpawner.orangeSquadron[ship].transform.position = ShipTopSpawnPosition3.topSpawner.transform.position;

            ShipBottomSpawnPosition0.bottomSpawner.orangeSquadron[ship].transform.position = ShipBottomSpawnPosition0.bottomSpawner.transform.position;
            ShipBottomSpawnPosition1.bottomSpawner.orangeSquadron[ship].transform.position = ShipBottomSpawnPosition1.bottomSpawner.transform.position;
            ShipBottomSpawnPosition2.bottomSpawner.orangeSquadron[ship].transform.position = ShipBottomSpawnPosition2.bottomSpawner.transform.position;
            ShipBottomSpawnPosition3.bottomSpawner.orangeSquadron[ship].transform.position = ShipBottomSpawnPosition3.bottomSpawner.transform.position;

            ShipLeftSpawnPosition0.leftSpawner.orangeSquadron[ship].transform.position = ShipLeftSpawnPosition0.leftSpawner.transform.position;
            ShipLeftSpawnPosition1.leftSpawner.orangeSquadron[ship].transform.position = ShipLeftSpawnPosition1.leftSpawner.transform.position;
            ShipLeftSpawnPosition2.leftSpawner.orangeSquadron[ship].transform.position = ShipLeftSpawnPosition2.leftSpawner.transform.position;
            ShipLeftSpawnPosition3.leftSpawner.orangeSquadron[ship].transform.position = ShipLeftSpawnPosition3.leftSpawner.transform.position;

            ShipRightSpawnPosition0.rightSpawner.orangeSquadron[ship].transform.position = ShipRightSpawnPosition0.rightSpawner.transform.position;
            ShipRightSpawnPosition1.rightSpawner.orangeSquadron[ship].transform.position = ShipRightSpawnPosition1.rightSpawner.transform.position;
            ShipRightSpawnPosition2.rightSpawner.orangeSquadron[ship].transform.position = ShipRightSpawnPosition2.rightSpawner.transform.position;
            ShipRightSpawnPosition3.rightSpawner.orangeSquadron[ship].transform.position = ShipRightSpawnPosition3.rightSpawner.transform.position;

            // yellow squadron
            ShipTopSpawnPosition0.topSpawner.yellowSquadron[ship].transform.position = ShipTopSpawnPosition0.topSpawner.transform.position;
            ShipTopSpawnPosition1.topSpawner.yellowSquadron[ship].transform.position = ShipTopSpawnPosition1.topSpawner.transform.position;
            ShipTopSpawnPosition2.topSpawner.yellowSquadron[ship].transform.position = ShipTopSpawnPosition2.topSpawner.transform.position;
            ShipTopSpawnPosition3.topSpawner.yellowSquadron[ship].transform.position = ShipTopSpawnPosition3.topSpawner.transform.position;

            ShipBottomSpawnPosition0.bottomSpawner.yellowSquadron[ship].transform.position = ShipBottomSpawnPosition0.bottomSpawner.transform.position;
            ShipBottomSpawnPosition1.bottomSpawner.yellowSquadron[ship].transform.position = ShipBottomSpawnPosition1.bottomSpawner.transform.position;
            ShipBottomSpawnPosition2.bottomSpawner.yellowSquadron[ship].transform.position = ShipBottomSpawnPosition2.bottomSpawner.transform.position;
            ShipBottomSpawnPosition3.bottomSpawner.yellowSquadron[ship].transform.position = ShipBottomSpawnPosition3.bottomSpawner.transform.position;

            ShipLeftSpawnPosition0.leftSpawner.yellowSquadron[ship].transform.position = ShipLeftSpawnPosition0.leftSpawner.transform.position;
            ShipLeftSpawnPosition1.leftSpawner.yellowSquadron[ship].transform.position = ShipLeftSpawnPosition1.leftSpawner.transform.position;
            ShipLeftSpawnPosition2.leftSpawner.yellowSquadron[ship].transform.position = ShipLeftSpawnPosition2.leftSpawner.transform.position;
            ShipLeftSpawnPosition3.leftSpawner.yellowSquadron[ship].transform.position = ShipLeftSpawnPosition3.leftSpawner.transform.position;

            ShipRightSpawnPosition0.rightSpawner.yellowSquadron[ship].transform.position = ShipRightSpawnPosition0.rightSpawner.transform.position;
            ShipRightSpawnPosition1.rightSpawner.yellowSquadron[ship].transform.position = ShipRightSpawnPosition1.rightSpawner.transform.position;
            ShipRightSpawnPosition2.rightSpawner.yellowSquadron[ship].transform.position = ShipRightSpawnPosition2.rightSpawner.transform.position;
            ShipRightSpawnPosition3.rightSpawner.yellowSquadron[ship].transform.position = ShipRightSpawnPosition3.rightSpawner.transform.position;

            // green squadron
            ShipTopSpawnPosition0.topSpawner.greenSquadron[ship].transform.position = ShipTopSpawnPosition0.topSpawner.transform.position;
            ShipTopSpawnPosition1.topSpawner.greenSquadron[ship].transform.position = ShipTopSpawnPosition1.topSpawner.transform.position;
            ShipTopSpawnPosition2.topSpawner.greenSquadron[ship].transform.position = ShipTopSpawnPosition2.topSpawner.transform.position;
            ShipTopSpawnPosition3.topSpawner.greenSquadron[ship].transform.position = ShipTopSpawnPosition3.topSpawner.transform.position;

            ShipBottomSpawnPosition0.bottomSpawner.greenSquadron[ship].transform.position = ShipBottomSpawnPosition0.bottomSpawner.transform.position;
            ShipBottomSpawnPosition1.bottomSpawner.greenSquadron[ship].transform.position = ShipBottomSpawnPosition1.bottomSpawner.transform.position;
            ShipBottomSpawnPosition2.bottomSpawner.greenSquadron[ship].transform.position = ShipBottomSpawnPosition2.bottomSpawner.transform.position;
            ShipBottomSpawnPosition3.bottomSpawner.greenSquadron[ship].transform.position = ShipBottomSpawnPosition3.bottomSpawner.transform.position;

            ShipLeftSpawnPosition0.leftSpawner.greenSquadron[ship].transform.position = ShipLeftSpawnPosition0.leftSpawner.transform.position;
            ShipLeftSpawnPosition1.leftSpawner.greenSquadron[ship].transform.position = ShipLeftSpawnPosition1.leftSpawner.transform.position;
            ShipLeftSpawnPosition2.leftSpawner.greenSquadron[ship].transform.position = ShipLeftSpawnPosition2.leftSpawner.transform.position;
            ShipLeftSpawnPosition3.leftSpawner.greenSquadron[ship].transform.position = ShipLeftSpawnPosition3.leftSpawner.transform.position;

            ShipRightSpawnPosition0.rightSpawner.greenSquadron[ship].transform.position = ShipRightSpawnPosition0.rightSpawner.transform.position;
            ShipRightSpawnPosition1.rightSpawner.greenSquadron[ship].transform.position = ShipRightSpawnPosition1.rightSpawner.transform.position;
            ShipRightSpawnPosition2.rightSpawner.greenSquadron[ship].transform.position = ShipRightSpawnPosition2.rightSpawner.transform.position;
            ShipRightSpawnPosition3.rightSpawner.greenSquadron[ship].transform.position = ShipRightSpawnPosition3.rightSpawner.transform.position;

            // blue squadron
            ShipTopSpawnPosition0.topSpawner.blueSquadron[ship].transform.position = ShipTopSpawnPosition0.topSpawner.transform.position;
            ShipTopSpawnPosition1.topSpawner.blueSquadron[ship].transform.position = ShipTopSpawnPosition1.topSpawner.transform.position;
            ShipTopSpawnPosition2.topSpawner.blueSquadron[ship].transform.position = ShipTopSpawnPosition2.topSpawner.transform.position;
            ShipTopSpawnPosition3.topSpawner.blueSquadron[ship].transform.position = ShipTopSpawnPosition3.topSpawner.transform.position;

            ShipBottomSpawnPosition0.bottomSpawner.blueSquadron[ship].transform.position = ShipBottomSpawnPosition0.bottomSpawner.transform.position;
            ShipBottomSpawnPosition1.bottomSpawner.blueSquadron[ship].transform.position = ShipBottomSpawnPosition1.bottomSpawner.transform.position;
            ShipBottomSpawnPosition2.bottomSpawner.blueSquadron[ship].transform.position = ShipBottomSpawnPosition2.bottomSpawner.transform.position;
            ShipBottomSpawnPosition3.bottomSpawner.blueSquadron[ship].transform.position = ShipBottomSpawnPosition3.bottomSpawner.transform.position;

            ShipLeftSpawnPosition0.leftSpawner.blueSquadron[ship].transform.position = ShipLeftSpawnPosition0.leftSpawner.transform.position;
            ShipLeftSpawnPosition1.leftSpawner.blueSquadron[ship].transform.position = ShipLeftSpawnPosition1.leftSpawner.transform.position;
            ShipLeftSpawnPosition2.leftSpawner.blueSquadron[ship].transform.position = ShipLeftSpawnPosition2.leftSpawner.transform.position;
            ShipLeftSpawnPosition3.leftSpawner.blueSquadron[ship].transform.position = ShipLeftSpawnPosition3.leftSpawner.transform.position;

            ShipRightSpawnPosition0.rightSpawner.blueSquadron[ship].transform.position = ShipRightSpawnPosition0.rightSpawner.transform.position;
            ShipRightSpawnPosition1.rightSpawner.blueSquadron[ship].transform.position = ShipRightSpawnPosition1.rightSpawner.transform.position;
            ShipRightSpawnPosition2.rightSpawner.blueSquadron[ship].transform.position = ShipRightSpawnPosition2.rightSpawner.transform.position;
            ShipRightSpawnPosition3.rightSpawner.blueSquadron[ship].transform.position = ShipRightSpawnPosition3.rightSpawner.transform.position;

            // cyan squadron
            ShipTopSpawnPosition0.topSpawner.cyanSquadron[ship].transform.position = ShipTopSpawnPosition0.topSpawner.transform.position;
            ShipTopSpawnPosition1.topSpawner.cyanSquadron[ship].transform.position = ShipTopSpawnPosition1.topSpawner.transform.position;
            ShipTopSpawnPosition2.topSpawner.cyanSquadron[ship].transform.position = ShipTopSpawnPosition2.topSpawner.transform.position;
            ShipTopSpawnPosition3.topSpawner.cyanSquadron[ship].transform.position = ShipTopSpawnPosition3.topSpawner.transform.position;

            ShipBottomSpawnPosition0.bottomSpawner.cyanSquadron[ship].transform.position = ShipBottomSpawnPosition0.bottomSpawner.transform.position;
            ShipBottomSpawnPosition1.bottomSpawner.cyanSquadron[ship].transform.position = ShipBottomSpawnPosition1.bottomSpawner.transform.position;
            ShipBottomSpawnPosition2.bottomSpawner.cyanSquadron[ship].transform.position = ShipBottomSpawnPosition2.bottomSpawner.transform.position;
            ShipBottomSpawnPosition3.bottomSpawner.cyanSquadron[ship].transform.position = ShipBottomSpawnPosition3.bottomSpawner.transform.position;

            ShipLeftSpawnPosition0.leftSpawner.cyanSquadron[ship].transform.position = ShipLeftSpawnPosition0.leftSpawner.transform.position;
            ShipLeftSpawnPosition1.leftSpawner.cyanSquadron[ship].transform.position = ShipLeftSpawnPosition1.leftSpawner.transform.position;
            ShipLeftSpawnPosition2.leftSpawner.cyanSquadron[ship].transform.position = ShipLeftSpawnPosition2.leftSpawner.transform.position;
            ShipLeftSpawnPosition3.leftSpawner.cyanSquadron[ship].transform.position = ShipLeftSpawnPosition3.leftSpawner.transform.position;

            ShipRightSpawnPosition0.rightSpawner.cyanSquadron[ship].transform.position = ShipRightSpawnPosition0.rightSpawner.transform.position;
            ShipRightSpawnPosition1.rightSpawner.cyanSquadron[ship].transform.position = ShipRightSpawnPosition1.rightSpawner.transform.position;
            ShipRightSpawnPosition2.rightSpawner.cyanSquadron[ship].transform.position = ShipRightSpawnPosition2.rightSpawner.transform.position;
            ShipRightSpawnPosition3.rightSpawner.cyanSquadron[ship].transform.position = ShipRightSpawnPosition3.rightSpawner.transform.position;

            // purple squadron
            ShipTopSpawnPosition0.topSpawner.purpleSquadron[ship].transform.position = ShipTopSpawnPosition0.topSpawner.transform.position;
            ShipTopSpawnPosition1.topSpawner.purpleSquadron[ship].transform.position = ShipTopSpawnPosition1.topSpawner.transform.position;
            ShipTopSpawnPosition2.topSpawner.purpleSquadron[ship].transform.position = ShipTopSpawnPosition2.topSpawner.transform.position;
            ShipTopSpawnPosition3.topSpawner.purpleSquadron[ship].transform.position = ShipTopSpawnPosition3.topSpawner.transform.position;

            ShipBottomSpawnPosition0.bottomSpawner.purpleSquadron[ship].transform.position = ShipBottomSpawnPosition0.bottomSpawner.transform.position;
            ShipBottomSpawnPosition1.bottomSpawner.purpleSquadron[ship].transform.position = ShipBottomSpawnPosition1.bottomSpawner.transform.position;
            ShipBottomSpawnPosition2.bottomSpawner.purpleSquadron[ship].transform.position = ShipBottomSpawnPosition2.bottomSpawner.transform.position;
            ShipBottomSpawnPosition3.bottomSpawner.purpleSquadron[ship].transform.position = ShipBottomSpawnPosition3.bottomSpawner.transform.position;

            ShipLeftSpawnPosition0.leftSpawner.purpleSquadron[ship].transform.position = ShipLeftSpawnPosition0.leftSpawner.transform.position;
            ShipLeftSpawnPosition1.leftSpawner.purpleSquadron[ship].transform.position = ShipLeftSpawnPosition1.leftSpawner.transform.position;
            ShipLeftSpawnPosition2.leftSpawner.purpleSquadron[ship].transform.position = ShipLeftSpawnPosition2.leftSpawner.transform.position;
            ShipLeftSpawnPosition3.leftSpawner.purpleSquadron[ship].transform.position = ShipLeftSpawnPosition3.leftSpawner.transform.position;

            ShipRightSpawnPosition0.rightSpawner.purpleSquadron[ship].transform.position = ShipRightSpawnPosition0.rightSpawner.transform.position;
            ShipRightSpawnPosition1.rightSpawner.purpleSquadron[ship].transform.position = ShipRightSpawnPosition1.rightSpawner.transform.position;
            ShipRightSpawnPosition2.rightSpawner.purpleSquadron[ship].transform.position = ShipRightSpawnPosition2.rightSpawner.transform.position;
            ShipRightSpawnPosition3.rightSpawner.purpleSquadron[ship].transform.position = ShipRightSpawnPosition3.rightSpawner.transform.position;*/
        }
    }


} // end of class
