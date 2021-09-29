using System;
using UnityEngine;

public class DefenderButton : MonoBehaviour {
    [SerializeField] private Defender defenderPrefab;
    private static readonly Color32 selectedColor = Color.white;
    private static readonly Color32 inactiveColor = new Color32( 130, 130, 130, 255 );

    private void OnMouseDown() {
        ToggleSelected();
    }
    
    private void ToggleSelected() {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach ( var button in buttons ) {
            button.SetInactive();
        }

        SetSelected();
    }

    private void SetSelected() {
        GetComponent<SpriteRenderer>().color = selectedColor;

        var defenderSpawners = FindObjectsOfType<DefenderSpawner>();
        foreach ( var defenderSpawner in defenderSpawners ) {
            defenderSpawner.SetSelectedDefender( defenderPrefab );
        }
    }
    
    private void SetInactive() {
        GetComponent<SpriteRenderer>().color = inactiveColor;
    }
}
