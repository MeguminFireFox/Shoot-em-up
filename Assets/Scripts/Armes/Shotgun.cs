using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shotgun : MonoBehaviour
{
    public Transform pointeur;
    private float currenttime = 0;
    public GameObject Bullet;
    private bool _effective = false;

    public void OnShoot(InputValue inputValue)
    {
        _effective = inputValue.isPressed;
    }

    private void FixedUpdate()
    {
        if (_effective == true)
        {
            currenttime += Time.deltaTime;
            if (currenttime > 0.80f)
            {
                for (int i = 0; i < 4; i++)
                {
                    Instantiate(Bullet, pointeur.position, transform.rotation);
                }
                currenttime = 0;
            }
        }
    }
}
