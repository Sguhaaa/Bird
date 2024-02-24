using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public LoseWindow LosePanel;
    
    public static GameManager instance;

    public AudioManager AudioManager;
    
    private void Start()
    {
        instance = this; 
        AudioManager.PlayButton(true);
        AudioManager.PlayOpenWindow(true);
        AudioManager.PlayBg(true);
    }

    public void Lose()
    {
        LosePanel.gameObject.SetActive(true);
        LosePanel.PlayerLose();
        Time.timeScale = 0;
    }
    
    public void RestartGame() {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
        Time.timeScale = 1;
    }
}
