using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    private bool effective = false;
    private float currenttime = 0;

    public void OnShoot(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            effective = true;
        }

        if (context.canceled)
        {
            effective = false;
        }
    }

    private void FixedUpdate()
    {
        if (effective == true)
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