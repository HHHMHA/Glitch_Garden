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
    }

    public void SetMovementSpeed( float speed ) {
        currentSpeed = speed;
    }

    public void Attack( GameObject target ) {
        animator.SetBool( IsAttacking, true );
        currentTarget = target;
    }
}
