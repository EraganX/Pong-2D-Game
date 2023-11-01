using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField]private GameObject score;
    ScoreScript scorescript;
    public bool isPlayer;

    private void Start()
    {
        scorescript = score.GetComponent<ScoreScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (scorescript != null && isPlayer && collision.gameObject.CompareTag("Ball"))
        {
            scorescript.UpdatePlayerScore();
            Destroy(collision);
            StartCoroutine(scorescript.BallInstantiate());
            
        }

        if (scorescript != null && !isPlayer && collision.gameObject.CompareTag("Ball"))
        {
            scorescript.UpdateEnemyScore();
            Destroy(collision);
            StartCoroutine(scorescript.BallInstantiate());
        }
    }
}
