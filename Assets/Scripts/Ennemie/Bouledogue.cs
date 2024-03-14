using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouledogue : MonoBehaviour
{
    public float HP = 3;
    private float speed = 4;
    public GameObject explos;
    public float degat = 1;
    public Transform pointeur;
    private float currenttime = 0;
    public GameObject Bullet;

    void FixedUpdate()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        currenttime += Time.deltaTime;

        if (currenttime > 2)
        {
            for (int i = 0; i < 10; i++)
            {
                Instantiate(Bullet, pointeur.position, transform.rotation);
            }
            currenttime = 0;
        }

        if (HP <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Balle1 balle1 = collision.GetComponent<Balle1>();
        Balle2 balle2 = collision.GetComponent<Balle2>();
        Balle3 balle3 = collision.GetComponent<Balle3>();
        Explosion explosion = collision.GetComponent<Explosion>();

        if (balle1 != null)
        {
            HP -= balle1.dammage;
            Destroy(balle1.gameObject);
        }
        if (balle2 != null)
        {
            HP -= balle2.dammage;
            Destroy(balle2.gameObject);
        }
        if (balle3 != null)
        {
            HP -= balle3.dammage;
            GameObject go = Instantiate(explos, transform.position, transform.rotation);
            Destroy(balle3.gameObject);
        }
        if (explosion != null)
        {
            HP -= explosion.dammage;
        }
    }
}
