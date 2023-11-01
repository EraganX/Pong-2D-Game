using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] private TMP_Text _playerScoreText,_enemyScoreText;
    Vector2 _BallPosition = new Vector2(0, 0);
    public int ScorePlayer;
    [SerializeField] private int _playerScore, _enemyScore;
    [SerializeField] private GameObject _BallPrefab, countForPlayer, countForEnemy;

    private void Start()
    {
        _playerScore = 0;
        _enemyScore = 0;
    }

    private void Update()
    {
        if ((_playerScore>=15) && (_playerScore>_enemyScore))
        {
            General.PLAYER_SCORE = _playerScore;
            General.ENEMY_SCORE  = _enemyScore;
            SceneManager.LoadScene("Finish");
        }

        if ((_enemyScore >= 15) && (_playerScore < _enemyScore))
        {
            General.PLAYER_SCORE = _playerScore;
            General.ENEMY_SCORE = _enemyScore;
            SceneManager.LoadScene("Finish");
        }
    }

    public void UpdatePlayerScore()
    {
        _playerScore += 1;
        _playerScoreText.text = _playerScore.ToString();
    }

    public void UpdateEnemyScore()
    {
        _enemyScore += 1;
        _enemyScoreText.text = _enemyScore.ToString();
    }
    
    public IEnumerator BallInstantiate()
    {
        yield return new WaitForSeconds(1f);
        Instantiate(_BallPrefab,_BallPosition,Quaternion.identity);
    }
}
