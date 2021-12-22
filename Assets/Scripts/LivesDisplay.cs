using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour {
    [SerializeField] private int lives = 5;
    private Text livesText;

    private void Start() {
        livesText = GetComponent<Text>();
        UpdateDisplay();
    }
    
    private void UpdateDisplay() {
        livesText.text = lives.ToString();
    }

    public void TakeLive() {
        TakeLives( 1 );
    }

    public void TakeLives( int livesToTake ) {
        lives -= livesToTake;
        UpdateDisplay();
    }
    public bool IsDead() {
        return lives <= 0;
    }
}
