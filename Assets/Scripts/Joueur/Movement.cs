using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private int VitessePersonnage = 6;
    private Vector2 _movementinput;
    private Rigidbody2D _rigidbody;
    private float currenttime = 0;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = _movementinput * VitessePersonnage;

        if (Time.timeScale == 0.33f)
        {
            VitessePersonnage = 18;

            currenttime += Time.deltaTime;

            if (currenttime >= 1)
            {
                VitessePersonnage = 6;
                currenttime = 0;
                Time.timeScale = 1;

            }
        }
    }

    public void OnMove(InputValue inputValue)
    {
        _movementinput = inputValue.Get<Vector2>();
    }
}