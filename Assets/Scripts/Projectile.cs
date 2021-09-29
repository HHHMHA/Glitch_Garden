using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float rotateSpeed = 1f;
    [SerializeField] private float damage = 50f;

    void Update() {
        transform.Translate( Vector3.right * moveSpeed * Time.deltaTime );
        transform.GetChild( 0 ).Rotate( Vector3.back * rotateSpeed );
    }

    private void OnTriggerEnter2D( Collider2D other ) {
        if ( !CanBeDamaged( other ) )
            return;
        
        var health = other.GetComponent<Health>();
        health.DealDamage( damage );
        Destroy( gameObject );
    }

    private static bool CanBeDamaged( Component component ) {
        var health = component.GetComponent<Health>();
        var attacker = component.GetComponent<Attacker>();
        return health && attacker;
    }
}
