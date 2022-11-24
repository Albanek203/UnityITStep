using UnityEngine;

public class Bomb : MonoBehaviour {
    [SerializeField]
    private AudioSource _bombSound;

    public void Die() {
        _bombSound.Play();
        Destroy(gameObject, 0.1f);
    }
}