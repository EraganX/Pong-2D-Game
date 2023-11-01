using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    public BallMovement _ballMovement;

    private void Bounce(Collision2D target)
    {
        Vector2 ballPosition = transform.position;
        Vector2 racketPosition = target.transform.position;
        float racketHeight = target.collider.bounds.size.y;
        float positionX;

        if (target.gameObject.CompareTag("Player"))
        {
            positionX = 1;
        }
        else
        {
            positionX = -1;
        }

        float positionY = (ballPosition.y - racketPosition.y)/racketHeight;

        _ballMovement.BallMoveDirection(new Vector2(positionX, positionY));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")||collision.gameObject.CompareTag("Player2"))
        {
            Bounce(collision);
            _ballMovement.HitCount++;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Counter2"))
        {
            Destroy(this.gameObject);
        }
    }


}
