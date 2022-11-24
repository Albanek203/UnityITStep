using UnityEngine;

public class BombSpawner : MonoBehaviour {
    [SerializeField]
    private Bomb _bombPrefab;
    [SerializeField]
    private int _bombCount;
    [SerializeField]
    private float _bombDistance;

    private void Start() {
        for (var i = 0; i < _bombCount; i++) {
            var transform1 = transform;
            var bomb = Instantiate(_bombPrefab, transform1.position, Quaternion.identity, transform1);
            bomb.transform.position = new Vector3(Random.Range(-_bombDistance, _bombDistance)
                                                , Random.Range(-_bombDistance, _bombDistance)
                                                , Random.Range(-_bombDistance, _bombDistance));
        }
    }
}