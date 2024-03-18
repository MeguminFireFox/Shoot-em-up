using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DUO_SOLO : MonoBehaviour
{
    public GameObject Playsolo;
    public GameObject Playduo;
    public Transform Pointeur;
    public TMP_Text Solo;
    public TMP_Text Duo;

    private bool _activated = false;

    void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Balle1 balle1 = collision.GetComponent<Balle1>();
        Balle2 balle2 = collision.GetComponent<Balle2>();
        Balle3 balle3 = collision.GetComponent<Balle3>();

        if (balle1 != null)
        {
            Destroy(balle1.gameObject);

            if (_activated == false)
            {
                Playsolo.SetActive(false);
                Playduo.SetActive(true);
                Solo.fontSize = 40;
                Duo.fontSize = 0;
                _activated = true;
            }

            else
            {
                Playsolo.SetActive(true);
                Playduo.SetActive(false);
                Solo.fontSize = 0;
                Duo.fontSize = 40;
                _activated = false;
            }
        }

        if (balle2 != null)
        {
            Destroy(balle2.gameObject);

            if (_activated == false)
            {
                Playsolo.SetActive(false);
                Playduo.SetActive(true);
                Solo.fontSize = 40;
                Duo.fontSize = 0;
                _activated = true;
            }

            else
            {
                Playsolo.SetActive(true);
                Playduo.SetActive(false);
                Solo.fontSize = 0;
                Duo.fontSize = 40;
                _activated = false;
            }
        }

        if (balle3 != null)
        {
            Destroy(balle3.gameObject);

            if (_activated == false)
            {
                Playsolo.SetActive(false);
                Playduo.SetActive(true);
                Solo.fontSize = 40;
                Duo.fontSize = 0;
                _activated = true;
            }

            else
            {
                Playsolo.SetActive(true);
                Playduo.SetActive(false);
                Solo.fontSize = 0;
                Duo.fontSize = 40;
                _activated = false;
            }
        }
    }
}
