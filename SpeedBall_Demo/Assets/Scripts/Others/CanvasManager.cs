using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] GameObject _gameOverPanel;
    [SerializeField] GameObject _winPanel;


    private void OnEnable()
    {
        GameManager.Instance.GameOverEvent += GameOverPanel;
        GameManager.Instance.WinEvent += WinPanel;
    }
    private void OnDisable()
    {
        GameManager.Instance.GameOverEvent -= GameOverPanel;
        GameManager.Instance.WinEvent -= WinPanel;
    }

    public void GameOverPanel()
    {
        _gameOverPanel.SetActive(true);
    }
    public void WinPanel()
    {
        _winPanel.SetActive(true);
    }

    public void ButtonLevelLoad(int level)
    {
        GameManager.Instance.LoadLevelScene(level);
    }

}
