using System;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour {
    [SerializeField] private GameObject defender;
    
    private void OnMouseDown() {
        Instantiate( defender, transform.position, Quaternion.identity );
    }
}