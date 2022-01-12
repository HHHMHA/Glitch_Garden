using System.Collections;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour, IObserver {
    [SerializeField] private Attacker[] attackerPrefabArray;
    [SerializeField] private int minSpawnDelay = 1;
    [SerializeField] private int maxSpawnDelay = 5;
    private GameTimer timer;

    private bool spawn = true;


    private void Start() {
        StartCoroutine( Spawner() );
        timer = FindObjectOfType<GameTimer>();
        timer.AddOnLevelTimerEndListener( this );
    }

    private void StopSpawning() {
        spawn = false;
    }

    private IEnumerator Spawner() {
        while ( spawn ) {
            Spawn();
            yield return new WaitForSeconds( Random.Range( minSpawnDelay, maxSpawnDelay ) );
        }
    }
    private void Spawn() {
        var prefab = GetAttackerPrefab();
        var attacker = Instantiate( prefab, transform.position, Quaternion.identity ) as Attacker;
        attacker.transform.parent = transform;
    }
    
    private Attacker GetAttackerPrefab() {
        var attackerIndex = Random.Range( 0, attackerPrefabArray.Length );
        return attackerPrefabArray[ attackerIndex ];
    }
    public void SendEventCompleteMessage() {
        StopSpawning();
    }
}
