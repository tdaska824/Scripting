using UnityEngine;
using TMPro;

// Requires a PlayerTemperature component with a public float currentTemperature
// (PlayerTemperature.cs is not part of this repository).
public class TemperatureUI : MonoBehaviour
{
    public PlayerTemperature playerTemperature;
    public TextMeshProUGUI temperatureText;

    public void UpdateTemperatureDisplay()
    {
        // Show the temperature with one decimal place
        temperatureText.text = playerTemperature.currentTemperature.ToString("F1");
    }
}
