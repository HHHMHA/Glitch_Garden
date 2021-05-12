using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreenLoader : MonoBehaviour {
    [SerializeField] private LevelLoader levelLoader;
    void Start()
    {
        levelLoader.LoadStartGameScreenWithDelay();
    }
}
