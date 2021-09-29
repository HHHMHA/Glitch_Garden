using System;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour {
    [SerializeField] private GameObject defender;
    private GameObject currentDefender;

    private void OnMouseDown() {
        SpawnDefender();
    }

    private void SpawnDefender() {
        if ( currentDefender )
            return;
        currentDefender = Instantiate( defender, transform.position, Quaternion.identity );
    }
}
