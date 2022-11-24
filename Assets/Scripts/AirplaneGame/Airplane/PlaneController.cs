using UnityEngine;

public class PlaneController : MonoBehaviour {
    [SerializeField]
    private Rigidbody _rigidbody;
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _torqueForce;

    private float _horizontalInput;
    private float _verticalInput;

    private void Update() {
        _rigidbody.velocity = transform.forward * _speed;
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate() {
        _rigidbody.AddTorque(0f, 0f, -_horizontalInput * _torqueForce);
        _rigidbody.AddTorque(_verticalInput * _torqueForce, 0f, 0f);
    }
}