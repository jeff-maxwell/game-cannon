using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour
{
    public Text shotsText;
    public Image circleImage;

    [HideInInspector]
    public bool audioEnabled = true;

    private int shots = 0;

    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    public void IncrementShots()
    {
        shots++;
        SetShotsValue();
    }

    public void ResetGame()
    {
        shots = 0;
        SetShotsValue();
    }

    private void SetShotsValue()
    {
        shotsText.text = $"Shots: {shots}";
    }

    public void ToggleAudio()
    {
        audioEnabled = !audioEnabled;
        circleImage.enabled = !audioEnabled;
    }
}
