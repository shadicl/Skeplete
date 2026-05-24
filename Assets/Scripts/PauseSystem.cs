using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseSystem : MonoBehaviour
{
    public Image pauseBackground;

    public void OnPauseButton()
    {
        pauseBackground.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }

    public void OnResumeButton()
    {
        pauseBackground.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

    public void OnRestartButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OnLevelSelectButton()
    {

        if (Time.timeScale == 0f) // if paused
        {
            Time.timeScale = 1f; // resume the game
        }

        SceneManager.LoadScene("LevelSelection");
    }

    public void OnExitButton()
    {

        if (Time.timeScale == 0f) // if paused
        {
            Time.timeScale = 1f; // resume the game
        }

        SceneManager.LoadScene("MainMenu");
    }
}
