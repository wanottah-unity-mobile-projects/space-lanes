
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
// Space Lanes 2024.02.28
//
// v2024.06.09
//

public class ShipSpawner : MonoBehaviour
{
    private Camera mainCamera;

    [SerializeField] private GameObject[] shipsInPool;

    private float timer;

    private int shipColour;

    private float topScreenBoundary;
    private float bottomScreenBoundary; 
    private float leftScreenBoundary;
    private float rightScreenBoundary;

    private float yTopPosition;
    private float yBottomPosition;
    private float xLeftPosition;
    private float xRightPosition;


    private void Start()
    {
        Initialise();

        StartCoroutine(SetScreenBoundaries());

        StartCoroutine(SpawnShips());
    }


    private void Initialise()
    {
        mainCamera = Camera.main;

        timer = 2f;
    }


    private IEnumerator SpawnShips()
    {
        yield return new WaitForSeconds(timer);

        shipColour = StargateSpawner.stargateSpawner.stargateColour;

        Instantiate(shipsInPool[shipColour], new Vector3(Random.Range(leftScreenBoundary, rightScreenBoundary), yTopPosition), Quaternion.Euler(0, 0, 180), transform);

        Instantiate(shipsInPool[shipColour], new Vector3(Random.Range(leftScreenBoundary, rightScreenBoundary), yBottomPosition), Quaternion.identity, transform);

        Instantiate(shipsInPool[shipColour], new Vector3(xLeftPosition, Random.Range(topScreenBoundary, bottomScreenBoundary)), Quaternion.Euler(0, 0, 270), transform);

        Instantiate(shipsInPool[shipColour], new Vector3(xRightPosition, Random.Range(topScreenBoundary, bottomScreenBoundary)), Quaternion.Euler(0, 0, 90), transform);
    }


    private IEnumerator SetScreenBoundaries()
    {
        yield return new WaitForSeconds(0.5f);

        topScreenBoundary = mainCamera.ViewportToWorldPoint(new Vector3(0, 0.1f, 0)).y;

        bottomScreenBoundary = mainCamera.ViewportToWorldPoint(new Vector3(0, 0.9f, 0)).y;

        leftScreenBoundary = mainCamera.ViewportToWorldPoint(new Vector3(0.1f, 0, 0)).x;

        rightScreenBoundary = mainCamera.ViewportToWorldPoint(new Vector3(0.9f, 0, 0)).x;

        SetSpawnPositions();
    }


    private void SetSpawnPositions()
    { 
        yTopPosition = mainCamera.ViewportToWorldPoint(new Vector2(0, 1.13f)).y;

        yBottomPosition = mainCamera.ViewportToWorldPoint(new Vector2(0, -0.13f)).y;

        xLeftPosition = mainCamera.ViewportToWorldPoint(new Vector2(-0.06f, 0)).x;

        xRightPosition = mainCamera.ViewportToWorldPoint(new Vector2(1.06f, 0)).x;
    }


} // end of class
