using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class Armes : MonoBehaviour
{
    public Transform Pointeur;
    public GameObject Automatique;
    public GameObject Shotgun;
    public GameObject Explosif;
    public AudioClip MeowMed;
    public AudioClip HissLong;

    private AudioSource _audiosource;
    private float _currenttime;
    private bool _effective = false;
    private int SwitchWeaponnumber = 1;

    void Start()
    {
        _audiosource = GetComponent<AudioSource>();
    }

    public void OnSwitch(InputValue putValue)
    {
        if (putValue.isPressed == true)
        {
            SwitchWeaponnumber += 1;
        }
    }

    public void OnShoot(InputValue inputValue)
    {
        _effective = inputValue.isPressed;
    }

    private void FixedUpdate()
    {

        if (SwitchWeaponnumber == 1)
        {
            if (_effective == true)
            {
                _currenttime += Time.deltaTime;
                if (_currenttime > 0.25f)
                {
                    GameObject go = Instantiate(Automatique, Pointeur.position, transform.rotation);
                    _currenttime = 0;
                }
            }
        }

        if (SwitchWeaponnumber == 2)
        {
            if (_effective == true)
            {
                _currenttime += Time.deltaTime;
                if (_currenttime > 0.80f)
                {
                    _audiosource.PlayOneShot(MeowMed);
                    for (int i = 0; i < 5; i++)
                    {
                        Instantiate(Shotgun, Pointeur.position, transform.rotation);
                    }
                    _currenttime = 0;
                }
            }
        }

        if (SwitchWeaponnumber == 3)
        {
            if (_effective == true)
            {
                _currenttime += Time.deltaTime;
                if (_currenttime > 1.25f)
                {
                    _audiosource.PlayOneShot(HissLong);
                    GameObject go = Instantiate(Explosif, Pointeur.position, transform.rotation);
                    _currenttime = 0;
                }
            }
        }

        if (SwitchWeaponnumber >= 4)
        {
            SwitchWeaponnumber = 1;
        }
    }
}
