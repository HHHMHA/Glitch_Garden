using System;
using UnityEngine;

public class Shooter : MonoBehaviour {
    [SerializeField] private GameObject projectile;
    private AttackerSpawner spawner;
    private Animator animator;
    private static readonly int Shooting = Animator.StringToHash( "Shooting" );

    private void Start() {
        animator = GetComponent<Animator>();
        SetLaneSpawner();
    }
    
    private void SetLaneSpawner() {
        var spawners = FindObjectsOfType<AttackerSpawner>();
        foreach ( var spawner in spawners ) {
            if ( !IsOnSameLane( spawner.transform ) ) continue;
            this.spawner = spawner;
            return;
        }
    }
    
    private bool IsOnSameLane( Transform transform ) {
        return Mathf.Abs( this.transform.position.y - transform.position.y ) <= Mathf.Epsilon;
    }

    private void Update() {
        FireOnAttacker();
    }
    
    private void FireOnAttacker() {
        if ( IsAttackerInLane() ) {
            animator.SetBool( Shooting, true );
            return;
        }
        
        animator.SetBool( Shooting, false );
    }
    
    private bool IsAttackerInLane() {
        return spawner.transform.childCount > 0;
    }

    public void Fire() {
        Instantiate( projectile, transform.GetChild( 0 ).GetChild( 0 ).position, Quaternion.identity );
    }
}
