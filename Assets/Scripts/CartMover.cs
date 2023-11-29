using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartMover : MonoBehaviour
{
    [SerializeField] float _movePower;
    [SerializeField] float _horizontalStraight;
    [SerializeField] Rigidbody _rb;

    float hImput;

    private void Update()
    {
        hImput = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        _rb.AddForce(Vector3.forward * _movePower,ForceMode.Impulse);
        _rb.AddForce(Vector3.right * _horizontalStraight * hImput, ForceMode.Impulse);
    }
}
