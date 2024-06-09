
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//
// Space Lanes v2024.02.28
//
// v2024.05.16
//

public class InputController : MonoBehaviour
{
    // reference to main camera
    private Camera gameCamera;



    private GameObject redTargetShip;

    private GameObject redChildShip1;

    private GameObject redChildShip2;

    private GameObject redChildShip3;


    private GameObject orangeTargetShip;

    private GameObject orangeChildShip1;

    private GameObject orangeChildShip2;

    private GameObject orangeChildShip3;


    private GameObject yellowTargetShip;

    private GameObject yellowChildShip1;

    private GameObject yellowChildShip2;

    private GameObject yellowChildShip3;


    private GameObject greenTargetShip;

    private GameObject greenChildShip1;

    private GameObject greenChildShip2;

    private GameObject greenChildShip3;


    private GameObject blueTargetShip;

    private GameObject blueChildShip1;

    private GameObject blueChildShip2;

    private GameObject blueChildShip3;


    private GameObject cyanTargetShip;

    private GameObject cyanChildShip1;

    private GameObject cyanChildShip2;

    private GameObject cyanChildShip3;


    private GameObject purpleTargetShip;

    private GameObject purpleChildShip1;

    private GameObject purpleChildShip2;

    private GameObject purpleChildShip3;


    public string targetShipTag;

    public int targetShipID;

    public int childShip1ID;

    public int childShip2ID;

    public int childShip3ID;

    public string shipColour;


    private bool redShipClicked;

    private bool orangeShipClicked;

    private bool yellowShipClicked;

    private bool greenShipClicked;

    private bool blueShipClicked;

    private bool cyanShipClicked;

    private bool purpleShipClicked;


    private void Awake()
    {
        gameCamera = Camera.main;
    }


    private void Update()
    {
        MoveShipsToTarget();
    }


    public void OnClick(InputAction.CallbackContext context)
    {
        if (GameController.gameController.inAttractMode)
        {
            return;
        }


        if (!context.started)
        {
            return;
        }

        var shipSelected = Physics2D.GetRayIntersection(gameCamera.ScreenPointToRay(Mouse.current.position.ReadValue()));

        if (!shipSelected.collider)
        {
            return;
        }


        else
        {
            targetShipTag = shipSelected.collider.tag;

            targetShipID = 0; // int.Parse(targetShipTag.Substring(targetShipTag.Length - 1));

            shipColour = targetShipTag.Substring(0, targetShipTag.Length - 2);
            

            switch (shipColour)
            {
                case "Red Ship":

                    redShipClicked = true;

                    GameController.gameController.redShipSpeed = 0f;

                    redTargetShip = ShipController.shipController.ships[targetShipID];

                    /*for (int childShipID = 0; childShipID < GameController.NUMBER_OF_SHIPS; childShipID++)
                    {
                        if (childShipID != targetShipID)
                        {
                            childShip1ID = childShipID;
                        }
                    }

                    for (int childShipID = 0; childShipID < GameController.NUMBER_OF_SHIPS; childShipID++)
                    {
                        if (childShipID != targetShipID && childShipID != childShip1ID)
                        {
                            childShip2ID = childShipID;
                        }
                    }

                    for (int childShipID = 0; childShipID < GameController.NUMBER_OF_SHIPS; childShipID++)
                    {
                        if (childShipID != targetShipID && childShipID != childShip1ID && childShipID != childShip2ID)
                        {
                            childShip3ID = childShipID;
                        }
                    }*/

                    childShip1ID = 1;
                    childShip2ID = 2;
                    childShip3ID = 3;

                    redChildShip1 = ShipController.shipController.ships[childShip1ID];

                    redChildShip2 = ShipController.shipController.ships[childShip2ID];

                    redChildShip3 = ShipController.shipController.ships[childShip3ID];
                    
                    break;

                /*case "Orange Ship":

                    orangeShipClicked = true;

                    GameController.gameController.orangeShipSpeed = 0f;

                    orangeTargetShip = GameController.gameController.orangeSquadron[targetShipID];

                    for (int childShipID = 0; childShipID < GameController.NUMBER_OF_SHIPS; childShipID++)
                    {
                        if (childShipID != targetShipID)
                        {
                            childShip1ID = childShipID;
                        }
                    }

                    for (int childShipID = 0; childShipID < GameController.NUMBER_OF_SHIPS; childShipID++)
                    {
                        if (childShipID != targetShipID && childShipID != childShip1ID)
                        {
                            childShip2ID = childShipID;
                        }
                    }

                    for (int childShipID = 0; childShipID < GameController.NUMBER_OF_SHIPS; childShipID++)
                    {
                        if (childShipID != targetShipID && childShipID != childShip1ID && childShipID != childShip2ID)
                        {
                            childShip3ID = childShipID;
                        }
                    }

                    orangeChildShip1 = GameController.gameController.orangeSquadron[childShip1ID];

                    orangeChildShip2 = GameController.gameController.orangeSquadron[childShip2ID];

                    orangeChildShip3 = GameController.gameController.orangeSquadron[childShip3ID];

                    break;

                case "Yellow Ship":

                    yellowShipClicked = true;

                    GameController.gameController.yellowShipSpeed = 0f;

                    yellowTargetShip = GameController.gameController.yellowSquadron[targetShipID];

                    for (int childShipID = 0; childShipID < GameController.NUMBER_OF_SHIPS; childShipID++)
                    {
                        if (childShipID != targetShipID)
                        {
                            childShip1ID = childShipID;
                        }
                    }

                    for (int childShipID = 0; childShipID < GameController.NUMBER_OF_SHIPS; childShipID++)
                    {
                        if (childShipID != targetShipID && childShipID != childShip1ID)
                        {
                            childShip2ID = childShipID;
                        }
                    }

                    for (int childShipID = 0; childShipID < GameController.NUMBER_OF_SHIPS; childShipID++)
                    {
                        if (childShipID != targetShipID && childShipID != childShip1ID && childShipID != childShip2ID)
                        {
                            childShip3ID = childShipID;
                        }
                    }

                    yellowChildShip1 = GameController.gameController.yellowSquadron[childShip1ID];

                    yellowChildShip2 = GameController.gameController.yellowSquadron[childShip2ID];

                    yellowChildShip3 = GameController.gameController.yellowSquadron[childShip3ID];

                    break;

                case "Green Ship":

                    greenShipClicked = true;

                    GameController.gameController.greenShipSpeed = 0f;

                    greenTargetShip = GameController.gameController.greenSquadron[targetShipID];

                    for (int childShipID = 0; childShipID < GameController.NUMBER_OF_SHIPS; childShipID++)
                    {
                        if (childShipID != targetShipID)
                        {
                            childShip1ID = childShipID;
                        }
                    }

                    for (int childShipID = 0; childShipID < GameController.NUMBER_OF_SHIPS; childShipID++)
                    {
                        if (childShipID != targetShipID && childShipID != childShip1ID)
                        {
                            childShip2ID = childShipID;
                        }
                    }

                    for (int childShipID = 0; childShipID < GameController.NUMBER_OF_SHIPS; childShipID++)
                    {
                        if (childShipID != targetShipID && childShipID != childShip1ID && childShipID != childShip2ID)
                        {
                            childShip3ID = childShipID;
                        }
                    }

                    greenChildShip1 = GameController.gameController.greenSquadron[childShip1ID];

                    greenChildShip2 = GameController.gameController.greenSquadron[childShip2ID];

                    greenChildShip3 = GameController.gameController.greenSquadron[childShip3ID];

                    break;

                case "Blue Ship":

                    blueShipClicked = true;

                    GameController.gameController.blueShipSpeed = 0f;

                    blueTargetShip = GameController.gameController.blueSquadron[targetShipID];

                    for (int childShipID = 0; childShipID < GameController.NUMBER_OF_SHIPS; childShipID++)
                    {
                        if (childShipID != targetShipID)
                        {
                            childShip1ID = childShipID;
                        }
                    }

                    for (int childShipID = 0; childShipID < GameController.NUMBER_OF_SHIPS; childShipID++)
                    {
                        if (childShipID != targetShipID && childShipID != childShip1ID)
                        {
                            childShip2ID = childShipID;
                        }
                    }

                    for (int childShipID = 0; childShipID < GameController.NUMBER_OF_SHIPS; childShipID++)
                    {
                        if (childShipID != targetShipID && childShipID != childShip1ID && childShipID != childShip2ID)
                        {
                            childShip3ID = childShipID;
                        }
                    }

                    blueChildShip1 = GameController.gameController.blueSquadron[childShip1ID];

                    blueChildShip2 = GameController.gameController.blueSquadron[childShip2ID];

                    blueChildShip3 = GameController.gameController.blueSquadron[childShip3ID];

                    break;

                case "Cyan Ship":

                    cyanShipClicked = true;

                    GameController.gameController.cyanShipSpeed = 0f;

                    cyanTargetShip = GameController.gameController.cyanSquadron[targetShipID];

                    for (int childShipID = 0; childShipID < GameController.NUMBER_OF_SHIPS; childShipID++)
                    {
                        if (childShipID != targetShipID)
                        {
                            childShip1ID = childShipID;
                        }
                    }

                    for (int childShipID = 0; childShipID < GameController.NUMBER_OF_SHIPS; childShipID++)
                    {
                        if (childShipID != targetShipID && childShipID != childShip1ID)
                        {
                            childShip2ID = childShipID;
                        }
                    }

                    for (int childShipID = 0; childShipID < GameController.NUMBER_OF_SHIPS; childShipID++)
                    {
                        if (childShipID != targetShipID && childShipID != childShip1ID && childShipID != childShip2ID)
                        {
                            childShip3ID = childShipID;
                        }
                    }

                    cyanChildShip1 = GameController.gameController.cyanSquadron[childShip1ID];

                    cyanChildShip2 = GameController.gameController.cyanSquadron[childShip2ID];

                    cyanChildShip3 = GameController.gameController.cyanSquadron[childShip3ID];

                    break;

                case "Purple Ship":

                    purpleShipClicked = true;

                    GameController.gameController.purpleShipSpeed = 0f;

                    purpleTargetShip = GameController.gameController.purpleSquadron[targetShipID];

                    for (int childShipID = 0; childShipID < GameController.NUMBER_OF_SHIPS; childShipID++)
                    {
                        if (childShipID != targetShipID)
                        {
                            childShip1ID = childShipID;
                        }
                    }

                    for (int childShipID = 0; childShipID < GameController.NUMBER_OF_SHIPS; childShipID++)
                    {
                        if (childShipID != targetShipID && childShipID != childShip1ID)
                        {
                            childShip2ID = childShipID;
                        }
                    }

                    for (int childShipID = 0; childShipID < GameController.NUMBER_OF_SHIPS; childShipID++)
                    {
                        if (childShipID != targetShipID && childShipID != childShip1ID && childShipID != childShip2ID)
                        {
                            childShip3ID = childShipID;
                        }
                    }

                    purpleChildShip1 = GameController.gameController.purpleSquadron[childShip1ID];

                    purpleChildShip2 = GameController.gameController.purpleSquadron[childShip2ID];

                    purpleChildShip3 = GameController.gameController.purpleSquadron[childShip3ID];

                    break;*/
            }
        }
    }


    private void MoveShipsToTarget()
    {
        if (redShipClicked)
        {
            MoveRedShips();
        }

        if (orangeShipClicked)
        {
            MoveOrangeShips();
        }

        if (yellowShipClicked)
        {
            MoveYellowShips();
        }

        if (greenShipClicked)
        {
            MoveGreenShips();
        }

        if (blueShipClicked)
        {
            MoveBlueShips();
        }

        if (cyanShipClicked)
        {
            MoveCyanShips();
        }

        if (purpleShipClicked)
        {
            MovePurpleShips();
        }
    }



    private void MoveRedShips()
    {
        redChildShip1.transform.position = Vector3.Lerp(redChildShip1.transform.position, redTargetShip.transform.position, 3f * Time.deltaTime);

        redChildShip2.transform.position = Vector3.Lerp(redChildShip2.transform.position, redTargetShip.transform.position, 3f * Time.deltaTime);

        redChildShip3.transform.position = Vector3.Lerp(redChildShip3.transform.position, redTargetShip.transform.position, 3f * Time.deltaTime);
    }


    private void MoveOrangeShips()
    {
        orangeChildShip1.transform.position = Vector3.Lerp(orangeChildShip1.transform.position, orangeTargetShip.transform.position, 3f * Time.deltaTime);

        orangeChildShip2.transform.position = Vector3.Lerp(orangeChildShip2.transform.position, orangeTargetShip.transform.position, 3f * Time.deltaTime);

        orangeChildShip3.transform.position = Vector3.Lerp(orangeChildShip3.transform.position, orangeTargetShip.transform.position, 3f * Time.deltaTime);
    }


    private void MoveYellowShips()
    {
        yellowChildShip1.transform.position = Vector3.Lerp(yellowChildShip1.transform.position, yellowTargetShip.transform.position, 3f * Time.deltaTime);

        yellowChildShip2.transform.position = Vector3.Lerp(yellowChildShip2.transform.position, yellowTargetShip.transform.position, 3f * Time.deltaTime);

        yellowChildShip3.transform.position = Vector3.Lerp(yellowChildShip3.transform.position, yellowTargetShip.transform.position, 3f * Time.deltaTime);
    }


    private void MoveGreenShips()
    {
        greenChildShip1.transform.position = Vector3.Lerp(greenChildShip1.transform.position, greenTargetShip.transform.position, 3f * Time.deltaTime);

        greenChildShip2.transform.position = Vector3.Lerp(greenChildShip2.transform.position, greenTargetShip.transform.position, 3f * Time.deltaTime);

        greenChildShip3.transform.position = Vector3.Lerp(greenChildShip3.transform.position, greenTargetShip.transform.position, 3f * Time.deltaTime);
    }


    private void MoveBlueShips()
    {

        blueChildShip1.transform.position = Vector3.Lerp(blueChildShip1.transform.position, blueTargetShip.transform.position, 3f * Time.deltaTime);

        blueChildShip2.transform.position = Vector3.Lerp(blueChildShip2.transform.position, blueTargetShip.transform.position, 3f * Time.deltaTime);

        blueChildShip3.transform.position = Vector3.Lerp(blueChildShip3.transform.position, blueTargetShip.transform.position, 3f * Time.deltaTime);
    }


    private void MoveCyanShips()
    {
        cyanChildShip1.transform.position = Vector3.Lerp(cyanChildShip1.transform.position, cyanTargetShip.transform.position, 3f * Time.deltaTime);

        cyanChildShip2.transform.position = Vector3.Lerp(cyanChildShip2.transform.position, cyanTargetShip.transform.position, 3f * Time.deltaTime);

        cyanChildShip3.transform.position = Vector3.Lerp(cyanChildShip3.transform.position, cyanTargetShip.transform.position, 3f * Time.deltaTime);
    }


    private void MovePurpleShips()
    {
        purpleChildShip1.transform.position = Vector3.Lerp(purpleChildShip1.transform.position, purpleTargetShip.transform.position, 3f * Time.deltaTime);

        purpleChildShip2.transform.position = Vector3.Lerp(purpleChildShip2.transform.position, purpleTargetShip.transform.position, 3f * Time.deltaTime);

        purpleChildShip3.transform.position = Vector3.Lerp(purpleChildShip3.transform.position, purpleTargetShip.transform.position, 3f * Time.deltaTime);
    }















    /*
    private GameObject redStargate;

    private GameObject redShip1;

    private GameObject redShip2;

    private GameObject redShip3;

    private GameObject redShip4;


    private GameObject orangeStargate;

    private GameObject orangeShip1;

    private GameObject orangeShip2;

    private GameObject orangeShip3;

    private GameObject orangeShip4;


    private GameObject yellowStargate;

    private GameObject yellowShip1;

    private GameObject yellowShip2;

    private GameObject yellowShip3;

    private GameObject yellowShip4;


    private GameObject greenStargate;

    private GameObject greenShip1;

    private GameObject greenShip2;

    private GameObject greenShip3;

    private GameObject greenShip4;


    private GameObject blueStargate;

    private GameObject blueShip1;

    private GameObject blueShip2;

    private GameObject blueShip3;

    private GameObject blueShip4;


    private GameObject cyanStargate;

    private GameObject cyanShip1;

    private GameObject cyanShip2;

    private GameObject cyanShip3;

    private GameObject cyanShip4;


    private GameObject purpleStargate;

    private GameObject purpleShip1;

    private GameObject purpleShip2;

    private GameObject purpleShip3;

    private GameObject purpleShip4;


    public string stargateTag;

    public string stargateColour;


    private bool redStargateClicked;

    private bool orangeStargateClicked;

    private bool yellowStargateClicked;

    private bool greenStargateClicked;

    private bool blueStargateClicked;

    private bool cyanStargateClicked;

    private bool purpleStargateClicked;


    private void Awake()
    {
        gameCamera = Camera.main;
    }


    private void Update()
    {
        MoveShipsToTarget();
    }


    public void OnClick(InputAction.CallbackContext context)
    {
        if (GameController.gameController.inAttractMode)
        {
            return;
        }


        if (!context.started)
        {
            return;
        }

        var stargateSelected = Physics2D.GetRayIntersection(gameCamera.ScreenPointToRay(Mouse.current.position.ReadValue()));

        if (!stargateSelected.collider)
        {
            return;
        }

        else
        {
            stargateTag = stargateSelected.collider.tag;

            stargateColour = stargateTag.Substring(0, stargateTag.Length - 2);


            Debug.Log(stargateTag + ", " + GameController.STARGATE_ID + ", " + stargateColour);



            switch (stargateColour)
            {
                case "Red Stargate":

                    redStargateClicked = true;

                    GameController.gameController.redStargateSpeed = 0f;

                    redStargate = GameController.gameController.redSquadron[GameController.STARGATE_ID];

                    redShip1 = GameController.gameController.redSquadron[GameController.SHIP_1_ID];

                    redShip2 = GameController.gameController.redSquadron[GameController.SHIP_2_ID];

                    redShip3 = GameController.gameController.redSquadron[GameController.SHIP_3_ID];

                    redShip4 = GameController.gameController.redSquadron[GameController.SHIP_4_ID];

                    break;


                case "Orange Stargate":

                    orangeStargateClicked = true;

                    GameController.gameController.orangeStargateSpeed = 0f;

                    orangeStargate = GameController.gameController.orangeSquadron[GameController.STARGATE_ID];

                    orangeShip1 = GameController.gameController.orangeSquadron[GameController.SHIP_1_ID];

                    orangeShip2 = GameController.gameController.orangeSquadron[GameController.SHIP_2_ID];

                    orangeShip3 = GameController.gameController.orangeSquadron[GameController.SHIP_3_ID];

                    orangeShip4 = GameController.gameController.orangeSquadron[GameController.SHIP_4_ID];

                    break;

                case "Yellow Stargate":

                    yellowStargateClicked = true;

                    GameController.gameController.yellowStargateSpeed = 0f;

                    yellowStargate = GameController.gameController.yellowSquadron[GameController.STARGATE_ID];

                    yellowShip1 = GameController.gameController.yellowSquadron[GameController.SHIP_1_ID];

                    yellowShip2 = GameController.gameController.yellowSquadron[GameController.SHIP_2_ID];

                    yellowShip3 = GameController.gameController.yellowSquadron[GameController.SHIP_3_ID];

                    yellowShip4 = GameController.gameController.yellowSquadron[GameController.SHIP_4_ID];

                    break;

                case "Green Stargate":

                    greenStargateClicked = true;

                    GameController.gameController.greenStargateSpeed = 0f;

                    greenStargate = GameController.gameController.greenSquadron[GameController.STARGATE_ID];

                    greenShip1 = GameController.gameController.greenSquadron[GameController.SHIP_1_ID];

                    greenShip2 = GameController.gameController.greenSquadron[GameController.SHIP_2_ID];

                    greenShip3 = GameController.gameController.greenSquadron[GameController.SHIP_3_ID];

                    greenShip4 = GameController.gameController.greenSquadron[GameController.SHIP_4_ID];

                    break;

                case "Blue Stargate":

                    blueStargateClicked = true;

                    GameController.gameController.blueStargateSpeed = 0f;

                    blueStargate = GameController.gameController.blueSquadron[GameController.STARGATE_ID];

                    blueShip1 = GameController.gameController.blueSquadron[GameController.SHIP_1_ID];

                    blueShip2 = GameController.gameController.blueSquadron[GameController.SHIP_2_ID];

                    blueShip3 = GameController.gameController.blueSquadron[GameController.SHIP_3_ID];

                    blueShip4 = GameController.gameController.blueSquadron[GameController.SHIP_4_ID];

                    break;

                case "Cyan Stargate":

                    cyanStargateClicked = true;

                    GameController.gameController.cyanStargateSpeed = 0f;

                    cyanStargate = GameController.gameController.cyanSquadron[GameController.STARGATE_ID];

                    cyanShip1 = GameController.gameController.cyanSquadron[GameController.SHIP_1_ID];

                    cyanShip2 = GameController.gameController.cyanSquadron[GameController.SHIP_2_ID];

                    cyanShip3 = GameController.gameController.cyanSquadron[GameController.SHIP_3_ID];

                    cyanShip4 = GameController.gameController.cyanSquadron[GameController.SHIP_4_ID];

                    break;

                case "Purple Stargate":

                    purpleStargateClicked = true;

                    GameController.gameController.purpleStargateSpeed = 0f;

                    purpleStargate = GameController.gameController.purpleSquadron[GameController.STARGATE_ID];

                    purpleShip1 = GameController.gameController.purpleSquadron[GameController.SHIP_1_ID];

                    purpleShip2 = GameController.gameController.purpleSquadron[GameController.SHIP_2_ID];

                    purpleShip3 = GameController.gameController.purpleSquadron[GameController.SHIP_3_ID];

                    purpleShip4 = GameController.gameController.purpleSquadron[GameController.SHIP_4_ID];

                    break;
            }
        }
    }


    private void MoveShipsToTarget()
    {
        if (redStargateClicked)
        {
            MoveRedShips();
        }
        
        if (orangeStargateClicked)
        {
            MoveOrangeShips();
        }
        
        if (yellowStargateClicked)
        {
            MoveYellowShips();
        }
        
        if (greenStargateClicked)
        {
            MoveGreenShips();
        }
        
        if (blueStargateClicked)
        {
            MoveBlueShips();
        }
        
        if (cyanStargateClicked)
        {
            MoveCyanShips();
        }
        
        if (purpleStargateClicked)
        {
            MovePurpleShips();
        }
    }



    private void MoveRedShips()
    {
        redShip1.transform.position = Vector3.Lerp(redShip1.transform.position, redStargate.transform.position, 3f * Time.deltaTime);

        redShip2.transform.position = Vector3.Lerp(redShip2.transform.position, redStargate.transform.position, 3f * Time.deltaTime);

        redShip3.transform.position = Vector3.Lerp(redShip3.transform.position, redStargate.transform.position, 3f * Time.deltaTime);

        redShip4.transform.position = Vector3.Lerp(redShip4.transform.position, redStargate.transform.position, 3f * Time.deltaTime);
    }


    private void MoveOrangeShips()
    {
        orangeShip1.transform.position = Vector3.Lerp(orangeShip1.transform.position, orangeStargate.transform.position, 3f * Time.deltaTime);

        orangeShip2.transform.position = Vector3.Lerp(orangeShip2.transform.position, orangeStargate.transform.position, 3f * Time.deltaTime);

        orangeShip3.transform.position = Vector3.Lerp(orangeShip3.transform.position, orangeStargate.transform.position, 3f * Time.deltaTime);

        orangeShip4.transform.position = Vector3.Lerp(orangeShip4.transform.position, orangeStargate.transform.position, 3f * Time.deltaTime);
    }


    private void MoveYellowShips()
    {
        yellowShip1.transform.position = Vector3.Lerp(yellowShip1.transform.position, yellowStargate.transform.position, 3f * Time.deltaTime);

        yellowShip2.transform.position = Vector3.Lerp(yellowShip2.transform.position, yellowStargate.transform.position, 3f * Time.deltaTime);

        yellowShip3.transform.position = Vector3.Lerp(yellowShip3.transform.position, yellowStargate.transform.position, 3f * Time.deltaTime);

        yellowShip4.transform.position = Vector3.Lerp(yellowShip4.transform.position, yellowStargate.transform.position, 3f * Time.deltaTime);
    }


    private void MoveGreenShips()
    {
        greenShip1.transform.position = Vector3.Lerp(greenShip1.transform.position, greenStargate.transform.position, 3f * Time.deltaTime);

        greenShip2.transform.position = Vector3.Lerp(greenShip2.transform.position, greenStargate.transform.position, 3f * Time.deltaTime);

        greenShip3.transform.position = Vector3.Lerp(greenShip3.transform.position, greenStargate.transform.position, 3f * Time.deltaTime);

        greenShip4.transform.position = Vector3.Lerp(greenShip4.transform.position, greenStargate.transform.position, 3f * Time.deltaTime);
    }


    private void MoveBlueShips()
    {

        blueShip1.transform.position = Vector3.Lerp(blueShip1.transform.position, blueStargate.transform.position, 3f * Time.deltaTime);

        blueShip2.transform.position = Vector3.Lerp(blueShip2.transform.position, blueStargate.transform.position, 3f * Time.deltaTime);

        blueShip3.transform.position = Vector3.Lerp(blueShip3.transform.position, blueStargate.transform.position, 3f * Time.deltaTime);

        blueShip4.transform.position = Vector3.Lerp(blueShip4.transform.position, blueStargate.transform.position, 3f * Time.deltaTime);
    }


    private void MoveCyanShips()
    {
        cyanShip1.transform.position = Vector3.Lerp(cyanShip1.transform.position, cyanStargate.transform.position, 3f * Time.deltaTime);

        cyanShip2.transform.position = Vector3.Lerp(cyanShip2.transform.position, cyanStargate.transform.position, 3f * Time.deltaTime);

        cyanShip3.transform.position = Vector3.Lerp(cyanShip3.transform.position, cyanStargate.transform.position, 3f * Time.deltaTime);

        cyanShip4.transform.position = Vector3.Lerp(cyanShip4.transform.position, cyanStargate.transform.position, 3f * Time.deltaTime);
    }


    private void MovePurpleShips()
    {
        purpleShip1.transform.position = Vector3.Lerp(purpleShip1.transform.position, purpleStargate.transform.position, 3f * Time.deltaTime);

        purpleShip2.transform.position = Vector3.Lerp(purpleShip2.transform.position, purpleStargate.transform.position, 3f * Time.deltaTime);

        purpleShip3.transform.position = Vector3.Lerp(purpleShip3.transform.position, purpleStargate.transform.position, 3f * Time.deltaTime);

        purpleShip4.transform.position = Vector3.Lerp(purpleShip4.transform.position, purpleStargate.transform.position, 3f * Time.deltaTime);
    }*/


} // end of class
