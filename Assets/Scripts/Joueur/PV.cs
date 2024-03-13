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

        if (pelotte != null)
        {
            Health -= pelotte.degat;
            Destroy(pelotte.gameObject);
        }
    }
}
