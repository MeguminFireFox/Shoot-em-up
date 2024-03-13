using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SbireDog : MonoBehaviour
{
    public float HP = 2;
    private float _speed = 6;
    public float Degat = 1;
    private float _distance;
    private float _preptime;
    private float _angle;
    private bool _position = false;
    public GameObject Explos;
    public GameObject Joueur;
    private Vector2 _direction;
    private Vector2 _emplacement;

    void FixedUpdate()
    {

        _preptime += Time.deltaTime;

        if (_position == false)
        {
            transform.Translate(Vector2.left * _speed * Time.deltaTime);
        }
        
        if (transform.position.x <= 7 && transform.position.x >= 6.5)
        {
            _position = true;

            _direction = Joueur.transform.position - transform.position;
            _direction.Normalize();
            _angle = Mathf.Atan2(_direction.y, _direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(Vector3.forward * _angle);

            _emplacement = Joueur.transform.position;
            
        }

        if (_preptime >= 6)
        {
            Debug.Log("hi");
            transform.position = Vector2.MoveTowards(transform.position, _emplacement, _speed * Time.deltaTime);
        }

        if (_preptime >= 10)
        {
            Destroy(gameObject);
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
