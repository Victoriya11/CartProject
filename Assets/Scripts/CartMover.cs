using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartMover : MonoBehaviour
{
    [SerializeField] float _movePower;
    [SerializeField] float _horizontalStraight;
    [SerializeField] Rigidbody _rb;

    float hImput;
    Vector3 distance = new Vector3(3f, 0, 0);

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position = transform.position + distance;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position = transform.position - distance;
        }
    }
    private void FixedUpdate()
    {
        _rb.AddForce(Vector3.forward * _movePower,ForceMode.Impulse);
        //_rb.AddForce(Vector3.right * _horizontalStraight * hImput, ForceMode.Impulse);
    }
}
