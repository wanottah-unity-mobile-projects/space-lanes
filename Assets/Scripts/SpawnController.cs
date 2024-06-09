
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
// Space Lanes v2024.02.28
//
// v2024.05.16
//

public class SpawnController : MonoBehaviour
{
    public static SpawnController spawnController;



    public Transform[] topSpawner;
    public Transform[] bottomSpawner;
    public Transform[] leftSpawner;
    public Transform[] rightSpawner;


    public int topSpawnPosition;
    public int bottomSpawnPosition;
    public int leftSpawnPosition;
    public int rightSpawnPosition;


    public int topShipColour;
    public int bottomShipColour;
    public int leftShipColour;
    public int rightShipColour;


    public int topShipID;
    public int bottomShipID;
    public int leftShipID;
    public int rightShipID;



    public float spawner;



    private void Awake()
    {
        spawnController = this;
    }


    private void Start()
    {
        InitialiseSpawner();
    }


    private void InitialiseSpawner()
    {
        spawner = GameController.gameController.spawnTimer;
    }


    public void RunSpawner()
    {
        spawner -= Time.deltaTime;

        if (spawner < 0f)
        {
            SelectRandomSpawnPositions();
        }
    }


    public void SelectRandomSpawnPositions()
    {
        // choose a random spawn position
        topSpawnPosition = Random.Range(0, topSpawner.Length);

        while (bottomSpawnPosition == topSpawnPosition)
        {
            bottomSpawnPosition = Random.Range(0, bottomSpawner.Length);
        }

        leftSpawnPosition = Random.Range(0, leftSpawner.Length);

        while (rightSpawnPosition == leftSpawnPosition)
        {
            rightSpawnPosition = Random.Range(0, rightSpawner.Length);
        }


        // choose a random ship colour
        // 0 - Red
        // 1 - Orange
        // 2 - Yellow
        // 3 - Green
        // 4 - Blue
        // 5 - Cyan
        // 6 - Purple

        topShipColour = GameController.RED; // Random.Range(0, GameController.NUMBER_OF_SHIP_COLOURS);

        // set the remaining ships to the same colour as the top
        bottomShipColour = topShipColour;

        leftShipColour = topShipColour;

        rightShipColour = topShipColour;


        // choose a random ship id
        topShipID = 0; // Random.Range(0, GameController.NUMBER_OF_SHIPS);

        //while (bottomShipID == topShipID)
        //{
        bottomShipID = 1; // Random.Range(0, GameController.NUMBER_OF_SHIPS);
                          //}

        //while ((leftShipID == topShipID) || (leftShipID == bottomShipID))
        //{
        leftShipID = 2; // Random.Range(0, GameController.NUMBER_OF_SHIPS);
                        //}

        //while ((rightShipID == topShipID) || (rightShipID == bottomShipID) || (rightShipID == leftShipID))
        //{
        rightShipID = 3; // Random.Range(0, GameController.NUMBER_OF_SHIPS);
        //}


        // select the chosen starting spawn position
        switch (topSpawnPosition)
        {
            case 0: ShipTopSpawnPosition0.topSpawner.SpawnShip(); break;

            case 1: ShipTopSpawnPosition1.topSpawner.SpawnShip(); break;

            case 2: ShipTopSpawnPosition2.topSpawner.SpawnShip(); break;

            case 3: ShipTopSpawnPosition3.topSpawner.SpawnShip(); break;
        }

        switch (bottomSpawnPosition)
        {
            case 0: ShipBottomSpawnPosition0.bottomSpawner.SpawnShip(); break;

            case 1: ShipBottomSpawnPosition1.bottomSpawner.SpawnShip(); break;

            case 2: ShipBottomSpawnPosition2.bottomSpawner.SpawnShip(); break;

            case 3: ShipBottomSpawnPosition3.bottomSpawner.SpawnShip(); break;
        }

        switch (leftSpawnPosition)
        {
            case 0: ShipLeftSpawnPosition0.leftSpawner.SpawnShip(); break;

            case 1: ShipLeftSpawnPosition1.leftSpawner.SpawnShip(); break;

            case 2: ShipLeftSpawnPosition2.leftSpawner.SpawnShip(); break;

            case 3: ShipLeftSpawnPosition3.leftSpawner.SpawnShip(); break;
        }

        switch (rightSpawnPosition)
        {
            case 0: ShipRightSpawnPosition0.rightSpawner.SpawnShip(); break;

            case 1: ShipRightSpawnPosition1.rightSpawner.SpawnShip(); break;

            case 2: ShipRightSpawnPosition2.rightSpawner.SpawnShip(); break;

            case 3: ShipRightSpawnPosition3.rightSpawner.SpawnShip(); break;
        }

        spawner = GameController.gameController.spawnTimer;
    }












    /*
    public Transform[] topSpawner;
    public Transform[] bottomSpawner;
    public Transform[] leftSpawner;
    public Transform[] rightSpawner;


    public int topSpawnPosition;
    public int bottomSpawnPosition;
    public int leftSpawnPosition;
    public int rightSpawnPosition;


    public int topStargateColour;
    public int bottomStargateColour;
    public int leftStargateColour;
    public int rightStargateColour;

    public int topShipColour;
    public int bottomShipColour;
    public int leftShipColour;
    public int rightShipColour;


    public int topStargateID;
    public int bottomStargateID;
    public int leftStargateID;
    public int rightStargateID;

    public int topShipID;
    public int bottomShipID;
    public int leftShipID;
    public int rightShipID;


    public float stargateSpawnTimer;

    public float shipSpawnTimer;

    private bool canSpawnStargate;

    private bool canSpawnShip;



    private void Awake()
    {
        spawnController = this;
    }


    private void Start()
    {
        Initialise();
    }


    private void Update()
    {
        //RunSpawnTimer();
    }


    private void Initialise()
    {
        canSpawnStargate = false;

        canSpawnShip = false;

        shipSpawnTimer = GameController.gameController.shipSpawnTimer;

        stargateSpawnTimer = GameController.gameController.stargateSpawnTimer;
    }


    public void RunSpawner()
    {
        // if we are not in attract mode
        if (!GameController.gameController.inAttractMode)
        {
            // then spawn stargates
            stargateSpawnTimer -= Time.deltaTime;

            if (stargateSpawnTimer < 0f)
            {
                canSpawnStargate = true;

                //SelectRandomStargateSpawnPosition();
            }
        }

        shipSpawnTimer -= Time.deltaTime;

        if (shipSpawnTimer < 0f)
        {
            canSpawnShip = true;

            SelectRandomShipSpawnPosition();
        }
    }


    public void SelectRandomStargateSpawnPosition()
    {
        // if we can spawn a stargate
        if (canSpawnStargate)
        {
            // choose a random spawn position
            topSpawnPosition = Random.Range(0, topSpawner.Length);

            while (bottomSpawnPosition == topSpawnPosition)
            {
                bottomSpawnPosition = Random.Range(0, bottomSpawner.Length);
            }

            leftSpawnPosition = Random.Range(0, leftSpawner.Length);

            while (rightSpawnPosition == leftSpawnPosition)
            {
                rightSpawnPosition = Random.Range(0, rightSpawner.Length);
            }


            // choose a random stargate colour
            // 0 - Red
            // 1 - Orange
            // 2 - Yellow
            // 3 - Green
            // 4 - Blue
            // 5 - Cyan
            // 6 - Purple

            topStargateColour = Random.Range(0, GameController.NUMBER_OF_COLOURS);

            while (bottomStargateColour == topStargateColour)
            {
                bottomStargateColour = Random.Range(0, GameController.NUMBER_OF_COLOURS);
            }

            leftStargateColour = Random.Range(0, GameController.NUMBER_OF_COLOURS);

            while (rightStargateColour == leftStargateColour)
            {
                rightStargateColour = Random.Range(0, GameController.NUMBER_OF_COLOURS);
            }


            ///topStargateID = GameController.gameController.stargateID;

            ///bottomShipID = GameController.gameController.stargateID;

            ///leftShipID = GameController.gameController.stargateID;

            ///rightShipID = GameController.gameController.stargateID;


            // select the chosen starting spawn position
            switch (topSpawnPosition)
            {
                case 0: StargateTopSpawnPosition0.topSpawner.SpawnStargate(); break;

                case 1: StargateTopSpawnPosition1.topSpawner.SpawnStargate(); break;

                case 2: StargateTopSpawnPosition2.topSpawner.SpawnStargate(); break;

                case 3: StargateTopSpawnPosition3.topSpawner.SpawnStargate(); break;
            }

            switch (bottomSpawnPosition)
            {
                case 0: StargateBottomSpawnPosition0.bottomSpawner.SpawnStargate(); break;

                case 1: StargateBottomSpawnPosition1.bottomSpawner.SpawnStargate(); break;

                case 2: StargateBottomSpawnPosition2.bottomSpawner.SpawnStargate(); break;

                case 3: StargateBottomSpawnPosition3.bottomSpawner.SpawnStargate(); break;
            }

            switch (leftSpawnPosition)
            {
                case 0: StargateLeftSpawnPosition0.leftSpawner.SpawnStargate(); break;

                case 1: StargateLeftSpawnPosition1.leftSpawner.SpawnStargate(); break;

                case 2: StargateLeftSpawnPosition2.leftSpawner.SpawnStargate(); break;

                case 3: StargateLeftSpawnPosition3.leftSpawner.SpawnStargate(); break;
            }

            switch (rightSpawnPosition)
            {
                case 0: StargateRightSpawnPosition0.rightSpawner.SpawnStargate(); break;

                case 1: StargateRightSpawnPosition1.rightSpawner.SpawnStargate(); break;

                case 2: StargateRightSpawnPosition2.rightSpawner.SpawnStargate(); break;

                case 3: StargateRightSpawnPosition3.rightSpawner.SpawnStargate(); break;
            }
        }


        // set the spawn flag to prevent further spawning
        canSpawnStargate = false;

        stargateSpawnTimer = GameController.gameController.stargateSpawnTimer;
    }

    

    public void SelectRandomShipSpawnPosition()
    {
        // if we can spawn a ship
        if (canSpawnShip)
        {
            // choose a random spawn position
            topSpawnPosition = 0; // Random.Range(0, topSpawner.Length);

            //while (bottomSpawnPosition == topSpawnPosition)
            //{
            bottomSpawnPosition = 1; // Random.Range(0, bottomSpawner.Length);
            //}

            /*leftSpawnPosition = 2; // Random.Range(0, leftSpawner.Length);

            //while (rightSpawnPosition == leftSpawnPosition)
            //{
                rightSpawnPosition = 3; // Random.Range(0, rightSpawner.Length);
            //}


            // choose a random ship colour
            // 0 - Red
            // 1 - Orange
            // 2 - Yellow
            // 3 - Green
            // 4 - Blue
            // 5 - Cyan
            // 6 - Purple

            topShipColour = GameController.RED; // Random.Range(0, GameController.NUMBER_OF_COLOURS);

            // set the remaining ships to the same colour as the top
            bottomShipColour = topShipColour;

            leftShipColour = topShipColour;

            rightShipColour = topShipColour;


            // set ship id
            topShipID = GameController.SHIP_1_ID;

            bottomShipID = GameController.SHIP_2_ID;

            leftShipID = GameController.SHIP_3_ID;

            rightShipID = GameController.SHIP_4_ID;


            /* choose a random ship id
            topShipID = Random.Range(0, GameController.NUMBER_OF_SHIPS);

            while (bottomShipID == topShipID)
            {
                bottomShipID = Random.Range(0, GameController.NUMBER_OF_SHIPS);
            }

            while ((leftShipID == topShipID) || (leftShipID == bottomShipID))
            {
                leftShipID = Random.Range(0, GameController.NUMBER_OF_SHIPS);
            }

            while ((rightShipID == topShipID) || (rightShipID == bottomShipID) || (rightShipID == leftShipID))
            {
                rightShipID = Random.Range(0, GameController.NUMBER_OF_SHIPS);
            }


            // select the chosen starting spawn position
            switch ( topSpawnPosition )
            {
                case 0: ShipTopSpawnPosition0.topSpawner.SpawnShip(); break;

                case 1: ShipTopSpawnPosition1.topSpawner.SpawnShip(); break;

                case 2: ShipTopSpawnPosition2.topSpawner.SpawnShip(); break;

                case 3: ShipTopSpawnPosition3.topSpawner.SpawnShip(); break;
            }

            switch ( bottomSpawnPosition )
            {
                case 0: ShipBottomSpawnPosition0.bottomSpawner.SpawnShip(); break;

                case 1: ShipBottomSpawnPosition1.bottomSpawner.SpawnShip(); break;

                case 2: ShipBottomSpawnPosition2.bottomSpawner.SpawnShip(); break;

                case 3: ShipBottomSpawnPosition3.bottomSpawner.SpawnShip(); break;
            }

            /*switch ( leftSpawnPosition )
            {
                case 0: ShipLeftSpawnPosition0.leftSpawner.SpawnShip(); break;

                case 1: ShipLeftSpawnPosition1.leftSpawner.SpawnShip(); break;

                case 2: ShipLeftSpawnPosition2.leftSpawner.SpawnShip(); break;

                case 3: ShipLeftSpawnPosition3.leftSpawner.SpawnShip(); break;
            }

            switch ( rightSpawnPosition )
            {
                case 0: ShipRightSpawnPosition0.rightSpawner.SpawnShip(); break;

                case 1: ShipRightSpawnPosition1.rightSpawner.SpawnShip(); break;

                case 2: ShipRightSpawnPosition2.rightSpawner.SpawnShip(); break;

                case 3: ShipRightSpawnPosition3.rightSpawner.SpawnShip(); break;
            }
        }


        // set the spawn flag to prevent further spawning
        canSpawnShip = false;

        shipSpawnTimer = GameController.gameController.shipSpawnTimer;
    }*/

}
