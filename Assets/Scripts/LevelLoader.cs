using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    private const int StartGameSceneIndex = 1;
    [SerializeField] private float loadDelay = 1f;
        
    public void LoadStartGameScreenWithDelay() {
        StartCoroutine( LoadSceneWithDelay( StartGameSceneIndex ) );
    }

    private IEnumerator LoadSceneWithDelay( int sceneIndex ) {
        yield return new WaitForSeconds( loadDelay );
        SceneManager.LoadScene( sceneIndex );
    }
}
