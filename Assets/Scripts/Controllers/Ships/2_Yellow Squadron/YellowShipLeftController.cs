
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
// Space Lanes v2024.02.28
//
// v2024.05.09
//

public class YellowShipLeftController : MonoBehaviour
{
    public int orbPoints;

    private Rigidbody2D shipRigidbody;

    private Vector3 shipDirection;

    private float rightBoundary;


    private void Start()
    {
        Initialise();
    }


    private void Initialise()
    {
        shipRigidbody = GetComponent<Rigidbody2D>();

        Vector3 right = new Vector3(1, 0, 0);

        shipDirection = right;

        rightBoundary = 10f;
    }


    void FixedUpdate()
    {
        MoveShip();
    }


    private void MoveShip()
    {
        shipRigidbody.velocity = GameController.gameController.blueShipSpeed * Time.deltaTime * shipDirection;

        if (transform.position.x > rightBoundary)
        {
            DestroyShip();
        }
    }


    private void DestroyShip()
    {
        gameObject.SetActive(false);
    }


    void OnCollisionEnter2D(Collision2D target)
    {
        if (target.collider.CompareTag("Player 1 Torpedo"))
        {
            DestroyShip();

            //GameController.gameController.UpdatePlayer1Score(orbPoints);
        }
    }


} // end of class
