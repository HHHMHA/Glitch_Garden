using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour {
    [SerializeField] [Tooltip( "Level time in seconds." )]
    private float levelTimeSeconds = 10;

    private Slider slider;

    private void Start() {
        slider = GetComponent<Slider>();
    }

    private float UpdateSliderProgress() {
        return slider.value = LevelProgressPercentage;
    }

    private float LevelProgressPercentage => Time.timeSinceLevelLoad / levelTimeSeconds;

    private bool LevelTimeFinished => Time.timeSinceLevelLoad >= levelTimeSeconds;

    void Update() {
        UpdateSliderProgress();

        if ( LevelTimeFinished ) {
            Debug.Log( "Done" );
        }
    }
}
