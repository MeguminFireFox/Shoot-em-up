using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PV : MonoBehaviour
{
    public float Health = 3;

    void FixedUpdate()
    {
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Pelotte pelotte = collision.GetComponent<Pelotte>();
        Defensive defensive = GetComponent<Defensive>();
        Bouledogue bouledogue = collision.GetComponent<Bouledogue>();
        Balleennemi1 balleennemi1 = collision.GetComponent<Balleennemi1>();
        
        if (pelotte != null)
        {
            Health -= pelotte.degat;
            if (defensive.Shieldisup == false )
            {
                defensive.Hprotected -= pelotte.degat;
            }
            Destroy(pelotte.gameObject);
            Destroy(GameObject.Find("Shield(Clone)"));
            Health = defensive.Hprotected;
        }

        if (bouledogue != null)
        {
            Health -= bouledogue.degat;
            if (defensive.Shieldisup == false)
            {
                defensive.Hprotected -= bouledogue.degat;
            }
            Destroy(bouledogue.gameObject);
            Destroy(GameObject.Find("Shield(Clone)"));
            Health = defensive.Hprotected;
        }

        if (balleennemi1 != null)
        {
            Health -= balleennemi1.dammage;
            if (defensive.Shieldisup == false)
            {
                defensive.Hprotected -= balleennemi1.dammage;
            }
            Destroy(balleennemi1.gameObject);
            Destroy(GameObject.Find("Shield(Clone)"));
            Health = defensive.Hprotected;
        }
    }
}
