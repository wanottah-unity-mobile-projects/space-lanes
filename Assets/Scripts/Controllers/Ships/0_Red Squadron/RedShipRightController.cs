
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
// Space Lanes v2024.02.28
//
// v2024.05.13
//

public class RedShipRightController : MonoBehaviour
{
    public int orbPoints;

    private Rigidbody2D shipRigidbody;

    private Vector3 shipDirection;

    private float leftBoundry;


    private void Start()
    {
        Initialise();
    }


    private void Initialise()
    {
        shipRigidbody = GetComponent<Rigidbody2D>();

        Vector3 left = new Vector3(-1, 0, 0);

        shipDirection = left;

        leftBoundry = -10f;
    }


    void FixedUpdate()
    {
        MoveShip();
    }


    private void MoveShip()
    {
        shipRigidbody.velocity = GameController.gameController.redShipSpeed * Time.deltaTime * shipDirection;

        if (transform.position.x < leftBoundry)
        {
            DestroyShip();
        }
    }


    private void DestroyShip()
    {
        gameObject.SetActive(false);
    }


    void OnCollisionEnter2D(Collision2D childShip)
    {
        if (childShip.collider.CompareTag("Player 1 Torpedo"))
        {
            DestroyShip();

            //GameController.gameController.UpdatePlayer1Score(orbPoints);
        }
    }


} // end of class
