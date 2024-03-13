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
    }
}
