using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour, IObserver {
    private bool NoAttackerLeft => FindObjectsOfType<Attacker>().Length == 0;
    private GameTimer timer;

    private void Start() {
        timer = FindObjectOfType<GameTimer>();
        timer.AddOnLevelTimerEndListener( this );
    }

    public void SendEventCompleteMessage() {
        if ( !NoAttackerLeft )
            return;

        Debug.Log( "Yes" );
    }
}
