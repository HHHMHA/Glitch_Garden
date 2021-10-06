using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour {
    [SerializeField] private int stars = 100;
    private Text starText;
    private const int StarsLimit = 999;
    
    void Start() {
        starText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay() {
        starText.text = stars.ToString();
    }

    public void AddStars( int starsToAdd ) {
        stars += starsToAdd;
        stars = Math.Min( stars, StarsLimit );
        UpdateDisplay();
    }

    public void SpendStars( int starsToSpend ) {
        if ( starsToSpend > stars ) {
            return;
        }
        stars -= starsToSpend;
        UpdateDisplay();
    }
}
