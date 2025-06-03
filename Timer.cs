using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int minutes = 1;
    public float seconds = 0f;

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
    }

    void RestartScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }
}

