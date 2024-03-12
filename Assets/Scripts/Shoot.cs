using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    private bool _effective = false;
    private float currenttime = 0;

    public void OnShoot(InputValue inputValue)
    {
        _effective = inputValue.isPressed;
    }

    private void FixedUpdate()
    {
        if (_effective == true)
        {
            currenttime += Time.deltaTime;
            if (currenttime > 0.25f)
            {
                GameObject go = Instantiate(bullet, transform.position, transform.rotation);
                currenttime = 0;
            }
        }
    }
}