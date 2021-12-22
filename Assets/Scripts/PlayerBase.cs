using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase : MonoBehaviour {
    private void OnTriggerEnter2D( Collider2D other ) {
        var livesDisplay = FindObjectOfType<LivesDisplay>();
        livesDisplay.TakeLive();
        if ( livesDisplay.IsDead() ) {
            FindObjectOfType<LevelLoader>().LoadGameOverScreenWithDelay();
        }
    }
}
