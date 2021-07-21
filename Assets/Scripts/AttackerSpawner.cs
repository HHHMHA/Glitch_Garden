using System.Collections;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour {
    [SerializeField] private GameObject prefab;
    [SerializeField] private int minSpawnDelay = 1;
    [SerializeField] private int maxSpawnDelay = 5;

    private bool spawn = true;


    private void Start() {
        StartCoroutine( Spawner() );
    }

    private IEnumerator Spawner() {
        while ( spawn ) {
            Instantiate( prefab, transform.position, Quaternion.identity );
            minSpawnDelay = 1;
            yield return new WaitForSeconds( Random.Range( minSpawnDelay, maxSpawnDelay ) );
        }
    }
}
