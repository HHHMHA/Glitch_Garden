using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour {
    private static readonly int JumpTrigger = Animator.StringToHash( "JumpTrigger" );
    
    private void OnTriggerEnter2D( Collider2D other ) {
        var otherGameObject = other.gameObject;

        if ( IsGraveStone( otherGameObject ) ) {
            JumpOver( otherGameObject );
            return;
        }

        if ( IsDefender( otherGameObject ) ) {
            Attack( otherGameObject );
        }
        
    }

    private static bool IsGraveStone( GameObject otherGameObject ) {
        return otherGameObject.GetComponent<Gravestone>() != null;
    }

    private void JumpOver( GameObject target ) {
        GetComponent<Animator>().SetTrigger( JumpTrigger );
    }
    
    private static bool IsDefender( GameObject otherGameObject ) {
        return otherGameObject.GetComponent<Defender>() != null;
    }

    private void Attack( GameObject otherGameObject ) {
        var attacker = GetComponent<Attacker>();
        attacker.Attack( otherGameObject );
    }
}
