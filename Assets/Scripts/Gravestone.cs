using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravestone : MonoBehaviour
{
    private void OnTriggerStay2D( Collider2D other ) {
        var attacker = other.GetComponent<Attacker>();

        if ( attacker ) {
            // TODO: start animation
        }
    }
}
