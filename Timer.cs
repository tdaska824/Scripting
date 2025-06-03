using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public int minutes = 1;
    public float seconds = 0f;
    public TextMeshProUGUI timerText;

    void Update()
    {
        if (minutes > 0 || seconds > 0)
        {
            seconds -= Time.deltaTime;

            if (seconds <= 0f)
            {
                if (minutes > 0)
                {
                    minutes--;
                    seconds += 59f;
                }
                else
                {
                    try
                    {
                        RestartScene();
                    }
                    catch (System.Exception e)
                    {
                        Debug.LogError("Failed to restart scene: " + e.Message);
                    }
                }
            }
        }
        int roundSeconds = Mathf.RoundToInt(seconds);
        timerText.text = minutes + ":" + roundSeconds;
    }

    void RestartScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }
}

