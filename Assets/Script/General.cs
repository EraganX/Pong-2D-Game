using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class General : MonoBehaviour
{
    public static float AI_PADDLE_SPEED;
    public static float PLAYER_PADDLE_SPEED;
    public static int PLAYER_SCORE, ENEMY_SCORE;

    public static void GameMode(int speedMode)
    {
        switch (speedMode) {
            case 0:
                AI_PADDLE_SPEED = 30f;
                PLAYER_PADDLE_SPEED = 10f;
                break;
            case 1:
                AI_PADDLE_SPEED = 50f;
                PLAYER_PADDLE_SPEED = 15f;
                break;
            case 2:
                AI_PADDLE_SPEED = 70f;
                PLAYER_PADDLE_SPEED = 20f;
                break;
            default:
                AI_PADDLE_SPEED = 50f;
                PLAYER_PADDLE_SPEED = 15f;
                break;
        }
    }
}
