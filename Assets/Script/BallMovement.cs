using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallMovement : MonoBehaviour
{
    Rigidbody2D _ballRigidBody;

    [SerializeField] private float speed = 10f;
    [SerializeField] private float addSpeed = 1.0f;
    public float HitCount;

    void Start()
    {
        _ballRigidBody = GetComponent<Rigidbody2D>();
        HitCount = addSpeed;
        BallMoveDirection(new Vector2(1, 0));
    }

    public void BallMoveDirection(Vector2 direction)
    {
        direction = direction.normalized;
        _ballRigidBody.velocity = direction * (speed+ HitCount);    
    }
 
}
