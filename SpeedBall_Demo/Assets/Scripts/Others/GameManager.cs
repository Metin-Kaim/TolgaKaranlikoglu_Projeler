using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public event System.Action GameOverEvent;
    public event System.Action WinEvent;


    private void OnEnable()
    {
        GameOverEvent += GameStop;
        WinEvent += GameStop;
    }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);
    }

    public void GameOver()
    {
        GameOverEvent?.Invoke();
    }
    public void Win()
    {
        WinEvent?.Invoke();
    }

    private void GameStop()
    {
        Time.timeScale = 0;
    }

    public void LoadLevelScene(int level)
    {
        StartCoroutine(LoadLevelSceneAsync(level));
    }
    IEnumerator LoadLevelSceneAsync(int level)
    {
        SceneManager.LoadSceneAsync(level);
        Time.timeScale = 1;
        yield return null;
    }


}
