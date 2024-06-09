
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
// Space Lanes v2024.02.28
//
// v2024.05.13
//

public class RedShipTopController : MonoBehaviour
{
    public int shipPoints;

    private Rigidbody2D shipRigidbody;

    private Vector3 shipDirection;

    private float bottomBoundary;


    private void Start()
    {
        Initialise();
    }


    private void Initialise()
    {
        shipRigidbody = GetComponent<Rigidbody2D>();

        Vector2 down = new Vector2(0, -1);

        shipDirection = down;

        bottomBoundary = -6f;
    }


    void FixedUpdate()
    {
        MoveShip();
    }


    private void MoveShip()
    {
        shipRigidbody.velocity = GameController.gameController.redShipSpeed * Time.deltaTime * shipDirection;

        if (transform.position.y < bottomBoundary)
        {
            DisableShip();
        }
    }


    private void DisableShip()
    {
        gameObject.SetActive(false);
    }


    void OnCollisionEnter2D(Collision2D target)
    {
        if (target.collider.CompareTag("Player 1 Torpedo"))
        {
            DisableShip();

            //GameController.gameController.UpdatePlayer1Score(orbPoints);
        }
    }


} // end of class
