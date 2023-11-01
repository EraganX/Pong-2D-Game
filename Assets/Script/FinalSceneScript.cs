using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalSceneScript : MonoBehaviour
{
    [SerializeField] private TMP_Text _winLoss;

    private void Start()
    {
        if (General.PLAYER_SCORE<General.ENEMY_SCORE)
        {
            DisplayWinLoss('l');
        }

        if (General.PLAYER_SCORE > General.ENEMY_SCORE)
        {
            DisplayWinLoss('w');
        }

    }

    public void DisplayWinLoss(char wl)
    {
        if (wl =='w')
        {
            _winLoss.text = "WIN";
        }
        else
        {
            _winLoss.text = "LOSS";
        }
    }
}
