using UnityEngine;

public class Health : MonoBehaviour {
    [SerializeField] private float health = 100f;
    [SerializeField] private GameObject deathFX;

    public void DealDamage( float damage ) {
        health -= damage;
        if (health > 0) return;
        TriggerDeathFX();
        Destroy( gameObject );
    }
    private void TriggerDeathFX() {
        if (!deathFX)
            return; 

        Instantiate( deathFX, transform.position, Quaternion.identity );
    }
}
