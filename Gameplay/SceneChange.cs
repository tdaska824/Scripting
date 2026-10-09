using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Name of the scene to load (it must be added to the Build Settings)
    public string sceneName;

    // Called when the player enters the trigger (for example a trap or an exit door)
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
