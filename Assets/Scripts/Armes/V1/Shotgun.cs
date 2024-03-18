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
    public AudioClip MeowMed;
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
            if (currenttime > 0.80f)
            {
                _audiosource.PlayOneShot(MeowMed);
                for (int i = 0; i < 5; i++)
                {
                    Instantiate(Bullet, pointeur.position, transform.rotation);
                }
                currenttime = 0;
            }
        }
    }
}
