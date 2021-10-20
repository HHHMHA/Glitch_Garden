using System;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour {
    private Defender defenderToPlace;
    private Defender currentDefender;

    private void OnMouseDown() {
        TrySpawnDefender();
    }

    private void TrySpawnDefender() {
        if ( !defenderToPlace )
            return;
        
        if ( !CanPlaceDefender() )
            return;

        currentDefender = Instantiate( defenderToPlace, transform.position, Quaternion.identity ) as Defender;
        FindObjectOfType<StarDisplay>().SpendStars( currentDefender.StarCost );

    }
    
    private bool CanPlaceDefender() {
        if ( currentDefender )
            return false;

        var totalStars = FindObjectOfType<StarDisplay>().Stars;
        var defenderCost = defenderToPlace.StarCost;

        return totalStars >= defenderCost;
    }

    public void SetSelectedDefender( Defender defender ) {
        defenderToPlace = defender;
    }
}
