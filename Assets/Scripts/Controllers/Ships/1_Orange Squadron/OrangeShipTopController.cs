
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
// Space Lanes v2024.02.28
//
// v2024.05.09
//

public class OrangeShipTopController : MonoBehaviour
{
    public int orbPoints;

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

        Vector3 down = new Vector3(0, -1, 0);

        shipDirection = down;

        bottomBoundary = -6f;
    }


    void FixedUpdate()
    {
        MoveShip();
    }


    private void MoveShip()
    {
        shipRigidbody.velocity = GameController.gameController.orangeShipSpeed * Time.deltaTime * shipDirection;

        if (transform.position.y < bottomBoundary)
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
