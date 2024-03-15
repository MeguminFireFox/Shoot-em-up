using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PV : MonoBehaviour
{
    public float Health = 3;
    [SerializeField] TMP_Text vieText;

    void FixedUpdate()
    {
        vieText.text = ($"Health : {Health}");

        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Pelotte pelotte = collision.GetComponent<Pelotte>();
        Defensive defensive = GetComponent<Defensive>();
        SbireDog sbireDog = collision.GetComponent<SbireDog>();
        SbireDogBeta followerDog = collision.GetComponent<SbireDogBeta>();
        Bouledogue bouledogue = collision.GetComponent<Bouledogue>();
        Balleennemi1 balleennemi1 = collision.GetComponent<Balleennemi1>();
        Corgi corgi = collision.GetComponent<Corgi>();
        Balleennemi2 balleennemi2 = collision.GetComponent<Balleennemi2>();
        
        if (pelotte != null)
        {
            Health -= pelotte.Degat;
            if (defensive.Shieldisup == false )
            {
                defensive.Hprotected -= pelotte.Degat;
            }
            Destroy(pelotte.gameObject);
            Destroy(GameObject.Find("Shield(Clone)"));
            Health = defensive.Hprotected;
        }

        if (sbireDog != null)
        {
            Health -= sbireDog.Degat;
            if (defensive.Shieldisup == false)
            {
                defensive.Hprotected -= sbireDog.Degat;
            }
            Destroy(sbireDog.gameObject);
            Destroy(GameObject.Find("Shield(Clone)"));
            Health = defensive.Hprotected;
        }

        if (followerDog != null)
        {
            Health -= followerDog.Degat;
            if (defensive.Shieldisup == false)
            {
                defensive.Hprotected -= followerDog.Degat;
            }
            Destroy(followerDog.gameObject);
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

        if (corgi != null)
        {
            Health -= corgi.Degat;
            if (defensive.Shieldisup == false)
            {
                defensive.Hprotected -= corgi.Degat;
            }
            Destroy(corgi.gameObject);
            Destroy(GameObject.Find("Shield(Clone)"));
            Health = defensive.Hprotected;
        }

        if (balleennemi2 != null)
        {
            Health -= balleennemi2.Dammage;
            if (defensive.Shieldisup == false)
            {
                defensive.Hprotected -= balleennemi2.Dammage;
            }
            Destroy(balleennemi2.gameObject);
            Destroy(GameObject.Find("Shield(Clone)"));
            Health = defensive.Hprotected;
        }
    }
}
