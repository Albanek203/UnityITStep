using UnityEngine;
using Random = UnityEngine.Random;

public class CoinSpawner : MonoBehaviour {
    [SerializeField]
    private Coin _coinPrefab;
    [SerializeField]
    private int _coinCount;
    [SerializeField]
    private float _coinDistance;

    private void Start() {
        for (var i = 0; i < _coinCount; i++) {
            var transform1 = transform;
            var coin = Instantiate(_coinPrefab, transform1.position, Quaternion.identity, transform1);
            coin.transform.Rotate(90, 0, 180);
            coin.transform.position = new Vector3(Random.Range(-_coinDistance, _coinDistance)
                                                , Random.Range(-_coinDistance, _coinDistance)
                                                , Random.Range(-_coinDistance, _coinDistance));
        }
    }
}