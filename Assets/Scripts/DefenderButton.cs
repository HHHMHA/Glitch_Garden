using System;
using UnityEngine;

public class DefenderButton : MonoBehaviour {
    private static readonly Color32 selectedColor = Color.white;
    private static readonly Color32 inactiveColor = new Color32( 130, 130, 130, 255 );
    
    private void OnMouseDown() {
        ToggleSelected();
    }
    
    public void ToggleSelected() {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach ( var button in buttons ) {
            button.SetInactive();
        }

        SetSelected();
    }

    public void SetSelected() {
        GetComponent<SpriteRenderer>().color = selectedColor;
    }
    
    public void SetInactive() {
        GetComponent<SpriteRenderer>().color = inactiveColor;
    }
}
