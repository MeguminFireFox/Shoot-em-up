using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private int VitessePersonnage = 6;
    private Vector2 _movementinput;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = _movementinput * VitessePersonnage;
    }

    public void OnMove(InputValue inputValue)
    {
        _movementinput = inputValue.Get<Vector2>();
    }
}