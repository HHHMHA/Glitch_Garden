using System.Collections;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour {
    [SerializeField] private Attacker prefab;
    [SerializeField] private int minSpawnDelay = 1;
    [SerializeField] private int maxSpawnDelay = 5;

    private bool spawn = true;


    private void Start() {
        StartCoroutine( Spawner() );
    }

    private IEnumerator Spawner() {
        while ( spawn ) {
            var attacker = Instantiate( prefab, transform.position, Quaternion.identity ) as Attacker;
            attacker.transform.parent = transform;
            yield return new WaitForSeconds( Random.Range( minSpawnDelay, maxSpawnDelay ) );
        }
    }
}
