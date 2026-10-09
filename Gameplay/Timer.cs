using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    // Starting time, set in the Inspector
    public int minutes = 1;
    public float seconds = 0f;
    public TextMeshProUGUI timerText;

    private float timeRemaining;
    private bool restarting;

    void Start()
    {
        timeRemaining = minutes * 60f + seconds;
    }

    void Update()
    {
        if (restarting)
        {
            return;
        }

        timeRemaining -= Time.deltaTime;

        // Time is up: reload the current scene
        if (timeRemaining <= 0f)
        {
            timeRemaining = 0f;
            restarting = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        // Show the time as m:ss, rounding up so it never shows 0:60
        int totalSeconds = Mathf.CeilToInt(timeRemaining);
        timerText.text = (totalSeconds / 60) + ":" + (totalSeconds % 60).ToString("00");
    }
}
