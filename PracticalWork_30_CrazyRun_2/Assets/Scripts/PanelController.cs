using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverPanel;

    [SerializeField] private GameObject _winPanel;

    public void GameOverPanel(Timer timer)
    {
        if (!timer.IsTimeForGame)
        {
            //Time.timeScale = 0;

            _gameOverPanel.SetActive(true);
        }        
    }

    public void WinPanel()
    {
        Time.timeScale = 0;

        _winPanel.SetActive(true);
    }
}
