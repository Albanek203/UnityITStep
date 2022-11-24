using UnityEngine;

public class PlaneMover : MonoBehaviour {
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.TryGetComponent(out Coin coin)) { coin.Die(); }
        if (collision.gameObject.TryGetComponent(out Bomb bomb)) { bomb.Die(); }
    }
}