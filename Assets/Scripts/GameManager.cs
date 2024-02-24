using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class GameManager : MonoBehaviour
{
    public LoseWindow LosePanel;
    
    public static GameManager instance;
    private void Start()
    {
        instance = this; 
    }

    public void Lose()
    {
        LosePanel.gameObject.SetActive(true);
        LosePanel.PlayerLose();
        Time.timeScale = 0;
    }
    
    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void LoadScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
        Time.timeScale = 1;
    }
}
