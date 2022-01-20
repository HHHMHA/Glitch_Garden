using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour, IObserver {
    // TODO: Create a field instead of a property to save time
    private bool NoAttackerLeft => FindObjectsOfType<Attacker>().Length == 0;
    private int NumberOfAttackers => FindObjectsOfType<Attacker>().Length;
    private GameTimer timer;
    [SerializeField] private GameObject winLabel;

    private void Start() {
        timer = FindObjectOfType<GameTimer>();
        timer.AddOnLevelTimerEndListener( this );
        winLabel.SetActive( false );
    }

    public void SendEventCompleteMessage() {
        if ( !NoAttackerLeft )
            return;

        StartCoroutine( WaitForWinCondition() );
        Debug.Log( "Yes" );
    }

    private IEnumerator WaitForWinCondition() {
        while ( NumberOfAttackers > 0 ) {
            yield return new WaitForSeconds( 1 );
        }

        HandleWinCondition();
    }
    private void HandleWinCondition() {
        winLabel.SetActive( true );
        GetComponent<LevelLoader>().LoadNextSceneWithDelay();
    }
}
