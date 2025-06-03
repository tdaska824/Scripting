using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TemperatureUI : MonoBehaviour
{
    
    public PlayerTemperature playerTemperature;
    public TextMeshProUGUI temperatureText;

    public void UpdateTemperatureDisplay()
    {
        float roundedTemperature = Mathf.Round(playerTemperature.currentTemperature * 10.0f) * 0.1f;

        temperatureText.text = roundedTemperature.ToString();
    }
}
