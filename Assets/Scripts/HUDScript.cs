using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour
{
    public Text shotsText;

    private int shots = 0;

    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    public void IncrementShots()
    {
        shotsText.text = $"Shots: {++shots}";
    }
}
