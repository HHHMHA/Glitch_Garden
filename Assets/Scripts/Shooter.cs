using UnityEngine;

public class Shooter : MonoBehaviour {
    [SerializeField] private GameObject projectile;
    
    public void Fire() {
        Instantiate( projectile, transform.GetChild( 0 ).GetChild( 0 ).position, Quaternion.identity );
    }
}
