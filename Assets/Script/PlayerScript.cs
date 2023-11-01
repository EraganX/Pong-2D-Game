using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Vector3 _playerPosition;
       
    private void Update()
    {
        _playerPosition = transform.position;
        _playerPosition += Vector3.up * Time.deltaTime * General.PLAYER_PADDLE_SPEED * Input.GetAxisRaw("Vertical");
        Debug.Log(General.PLAYER_PADDLE_SPEED);
        LimitBound();
    }

    private void LimitBound()
    {
        if (_playerPosition.y < -5f)
        {
            _playerPosition.y = -5f;
        }
        else if (_playerPosition.y > 5f)
        {
            _playerPosition.y = 5f;
        }
        transform.position = _playerPosition;
    }
}
