using System;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour {
    private Defender defenderToPlace;
    private Defender currentDefender;

    private void OnMouseDown() {
        SpawnDefender();
    }

    private void SpawnDefender() {
        if ( currentDefender )
            return;
        currentDefender = Instantiate( defenderToPlace, transform.position, Quaternion.identity ) as Defender;
    }

    public void SetSelectedDefender( Defender defender ) {
        defenderToPlace = defender;
    }
}
