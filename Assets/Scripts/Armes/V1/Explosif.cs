using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Explosif : MonoBehaviour
{
    public Transform pointeur;
    public GameObject bullet;
    private bool _effective = false;
    private float currenttime = 0;
    public AudioClip HissLong;
    private AudioSource _audiosource;

    private void Start()
    {
        _audiosource = GetComponent<AudioSource>();
    }

    public void OnShoot(InputValue inputValue)
    {
        _effective = inputValue.isPressed;
    }

    private void FixedUpdate()
    {

        if (_effective == true)
        {
            currenttime += Time.deltaTime;
            if (currenttime > 1.25f)
            {
                _audiosource.PlayOneShot(HissLong);
                GameObject go = Instantiate(bullet, pointeur.position, transform.rotation);
                currenttime = 0;
            }
        }
    }
}
