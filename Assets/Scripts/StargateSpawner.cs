
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
// Space Lanes 2024.02.28
//
// v2024.06.09
//

public class StargateSpawner : MonoBehaviour
{
    public static StargateSpawner stargateSpawner;

    private Camera mainCamera;

    [SerializeField] private GameObject[] stargatesInPool;

    private float timer;

    public int stargateColour;

    private float topScreenBoundary;
    private float bottomScreenBoundary; 
    private float leftScreenBoundary;
    private float rightScreenBoundary;

    private float yTopPosition;
    private float yBottomPosition;
    private float xLeftPosition;
    private float xRightPosition;

    private enum SpawnPosition
    { 
        Top, 
        Bottom, 
        Left, 
        Right 
    };

    private SpawnPosition spawnPosition;

    private int spawnPositions;


    private void Awake()
    {
        stargateSpawner = this;
    }


    private void Start()
    {
        Initialise();

        StartCoroutine(SetScreenBoundaries());

        StartCoroutine(SpawnStargates());
    }


    private void Initialise()
    {
        mainCamera = Camera.main;

        timer = 1f;

        spawnPositions = System.Enum.GetNames(typeof(SpawnPosition)).Length;
    }


    private IEnumerator SpawnStargates()
    {
        yield return new WaitForSeconds(timer);

        spawnPosition = (SpawnPosition)Random.Range(0, spawnPositions);

        stargateColour = Random.Range(0, stargatesInPool.Length);

        switch (spawnPosition)
        {
            case SpawnPosition.Top:

                Instantiate(stargatesInPool[stargateColour], new Vector3(Random.Range(leftScreenBoundary, rightScreenBoundary), yTopPosition), Quaternion.identity, transform);

                break;

            case SpawnPosition.Bottom:

                Instantiate(stargatesInPool[stargateColour], new Vector3(Random.Range(leftScreenBoundary, rightScreenBoundary), yBottomPosition), Quaternion.identity, transform);

                break;

            case SpawnPosition.Left:

                Instantiate(stargatesInPool[stargateColour], new Vector3(xLeftPosition, Random.Range(topScreenBoundary, bottomScreenBoundary)), Quaternion.identity, transform);

                break;

            case SpawnPosition.Right:

                Instantiate(stargatesInPool[stargateColour], new Vector3(xRightPosition, Random.Range(topScreenBoundary, bottomScreenBoundary)), Quaternion.identity, transform);

                break;
        }
    }


    private IEnumerator SetScreenBoundaries()
    {
        yield return new WaitForSeconds(0.4f);

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
