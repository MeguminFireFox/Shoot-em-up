using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Corgi : MonoBehaviour
{
    public float HP = 6;
    private float _speed = 6;
    public float Degat = 1;
    private float _time;
    private bool _position = false;
    public GameObject Explos;
    public GameObject Bullet;
    public Transform Pointeur;

    void FixedUpdate()
    {
        _time += Time.deltaTime;

        if (_position == false)
        {
            transform.Translate(Vector2.left * _speed * Time.deltaTime);
        }

        if (transform.position.x <= 7 && transform.position.x >= 6.5)
        {
            _position = true;
        }

        if (_time >= 2.5f)
        {
            Instantiate(Bullet, Pointeur.position, transform.rotation);

            _time = 0;
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
            GameObject go = Instantiate(Explos, transform.position, transform.rotation);
            Destroy(balle3.gameObject);
        }
        if (explosion != null)
        {
            HP -= explosion.dammage;
        }
    }
}
