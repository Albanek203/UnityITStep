using UnityEngine;

public class PlayerMover : MonoBehaviour {
    [SerializeField]
    private Rigidbody _rigidbody;
    [SerializeField]
    private float _speed = 5f;
    [SerializeField]
    private float _rotationSpeed = 10f;

    private void FixedUpdate() {
        var h = Input.GetAxisRaw("Horizontal");
        var v = Input.GetAxisRaw("Vertical");
        var r = Input.GetAxisRaw("Mouse X");
        var velocity = new Vector3(h, 0, v) * _speed;
        velocity.y = _rigidbody.velocity.y;
        var worldVelocity = transform.TransformVector(velocity);
        _rigidbody.velocity = worldVelocity;
        transform.Rotate(0, r * _rotationSpeed, 0);
    }
}