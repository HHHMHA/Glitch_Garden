using System;
using UnityEngine;

public class Attacker : MonoBehaviour {
    private float currentSpeed = 0f;
    private GameObject currentTarget;
    private Animator animator;
    private static readonly int IsAttacking = Animator.StringToHash( "isAttacking" );

    private void Start() {
        animator = GetComponent<Animator>();
    }

    private void Update() {
        transform.Translate( Vector2.left * ( currentSpeed * Time.deltaTime ) );
        UpdateAnimationState();
    }
    private void UpdateAnimationState() {
        StopAttackingOnTargetLoss();
    }
    private void StopAttackingOnTargetLoss() {
        if ( currentTarget )
            return;

        animator.SetBool( IsAttacking, false );
    }

    public void SetMovementSpeed( float speed ) {
        currentSpeed = speed;
    }

    public void Attack( GameObject target ) {
        animator.SetBool( IsAttacking, true );
        currentTarget = target;
    }

    public void StrikeCurrentTarget( float damage ) {
        if ( !currentTarget )
            return;

        var health = currentTarget.GetComponent<Health>();
        if ( !health )
            return;

        health.DealDamage( damage );
    }
}
