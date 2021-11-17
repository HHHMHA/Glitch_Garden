using System;
using UnityEngine;

public class Lizard : MonoBehaviour {
        private void OnTriggerEnter2D( Collider2D other ) {
                var target = other.gameObject;
                if ( target.GetComponent<Defender>() == null ) return;
                var attacker = GetComponent<Attacker>();
                attacker.Attack( target );
        }
}
