using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    private const int StartGameSceneIndex = 1;
    private const int GameOverSceneIndex = 3;
    [SerializeField] private float loadDelay = 1f;
        
    public void LoadStartGameScreenWithDelay() {
        StartCoroutine( LoadSceneWithDelay( StartGameSceneIndex ) );
    }
    
    public void LoadGameOverScreenWithDelay() {
        StartCoroutine( LoadSceneWithDelay( GameOverSceneIndex ) );
    }
    
    public void RestartScene() {
        StartCoroutine( LoadSceneWithDelay( SceneManager.GetActiveScene().buildIndex ) );
    }
    
    public void LoadNextSceneWithDelay() {
        StartCoroutine( LoadSceneWithDelay( SceneManager.GetActiveScene().buildIndex + 1 ) );
    }

    private IEnumerator LoadSceneWithDelay( int sceneIndex ) {
        // Make Sure We return to normal time
        Time.timeScale = 1;
        yield return new WaitForSeconds( loadDelay );
        SceneManager.LoadScene( sceneIndex );
    }
}
