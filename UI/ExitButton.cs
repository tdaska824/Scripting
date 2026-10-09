using UnityEngine;

public class ExitButton : MonoBehaviour
{
    // Hook this up to the button's OnClick event
    public void ExitGame()
    {
#if UNITY_EDITOR
        // Application.Quit() does nothing in the editor, so stop play mode instead
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
