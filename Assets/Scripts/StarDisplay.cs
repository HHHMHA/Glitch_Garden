using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour {
    [SerializeField] private int stars = 100;
    private Text starText;
    private const int StarsLimit = 999;

    public int Stars => stars;

    void Start() {
        starText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay() {
        starText.text = Stars.ToString();
    }

    public void AddStars( int starsToAdd ) {
        stars = Stars + starsToAdd;
        stars = Math.Min( Stars, StarsLimit );
        UpdateDisplay();
    }

    public void SpendStars( int starsToSpend ) {
        if ( starsToSpend > Stars ) {
            return;
        }
        stars = Stars - starsToSpend;
        UpdateDisplay();
    }
}
