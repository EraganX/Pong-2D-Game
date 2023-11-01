using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ai : MonoBehaviour
{
    private GameObject _ball;
    private Rigidbody2D _rigidbody2D;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        MoveAiPaddle(General.AI_PADDLE_SPEED);
    }

    public void MoveAiPaddle(float speed)
    {
        if (_ball != null)
        {
            Vector2 _predictedLocation = new Vector2(0, _ball.transform.position.y);
            _rigidbody2D.MovePosition(Vector2.MoveTowards(transform.position, _predictedLocation, Time.deltaTime * speed));
        }
        else
        {
            _ball = GameObject.FindGameObjectWithTag("Ball");

        }

    }
}
