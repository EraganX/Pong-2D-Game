using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuScript : MonoBehaviour
{
    public GameObject _pauseMenu;
    public GameObject _pauseButton;
    public bool isPaused;

    private void Start()
    {
        _pauseMenu.SetActive(false);
        _pauseButton.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();   
            }
            else
            {
                PauseGame();    
            }
        }
    }

    public void PauseGame()
    {
        _pauseMenu.SetActive(true);
        _pauseButton.SetActive(false);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        _pauseMenu.SetActive(false);
        _pauseButton.SetActive(true);
        Time.timeScale = 1f;
        isPaused = false;
    }
}
