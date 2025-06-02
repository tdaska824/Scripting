using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Name of the scene to reload
    public string sceneName;

    // Method triggered when player enters the trap trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Reload the scene using its name
            EditorSceneManager.LoadScene(sceneName);
        }
    }
}
