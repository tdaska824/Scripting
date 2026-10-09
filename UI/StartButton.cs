using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    // Build index of the scene to load (0 is usually the main menu)
    public int gameSceneIndex = 1;

    // Hook this up to the button's OnClick event
    public void StartGame()
    {
        SceneManager.LoadScene(gameSceneIndex);
    }
}
