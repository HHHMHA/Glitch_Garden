using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Attacker : MonoBehaviour {
    [SerializeField]
    [Range( 0f, 5f )] 
    private float speed = .5f;

    private void Update() {
        transform.Translate( Vector2.left * (speed * Time.deltaTime) );
    }
}
