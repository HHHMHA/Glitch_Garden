using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float rotateSpeed = 1f;
    void Update() {
        transform.Translate( Vector3.right * moveSpeed * Time.deltaTime );
        transform.GetChild( 0 ).Rotate( Vector3.back * rotateSpeed );
    }
}
