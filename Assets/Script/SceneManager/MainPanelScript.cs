using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainPanelScript : MonoBehaviour
{
    public GameObject mainPanel, playPanel;

    private void Start()
    {

        mainPanel.SetActive(true);
        playPanel.SetActive(false);
    }

    public void PlayPanelActivation()
    {
        mainPanel.SetActive(false);
        playPanel.SetActive(true);
    }

    public void MainPanelActivation()
    {
        mainPanel.SetActive(true);
        playPanel.SetActive(false);
    }
}
