using UnityEngine;

public class PlaneMover : MonoBehaviour {
    [SerializeField]
    private Material _planeRedTexture;

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.TryGetComponent(out Coin coin)) { coin.Die(); }
        if (collision.gameObject.TryGetComponent(out Bomb bomb)) {
            var grandChild = this.gameObject.transform.GetChild(0).gameObject;
            grandChild.GetComponent<Renderer>().material = _planeRedTexture;
            bomb.Die();
        }
    }
}