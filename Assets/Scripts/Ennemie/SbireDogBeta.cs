using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SbireDogBeta : MonoBehaviour
{
    public float HP = 2;
    private float _speed = 3;
    public float Degat = 1;
    private float _distance;
    private float _choix = 0;
    public GameObject Explos;
    public GameObject Joueur;

    void Start()
    {
        if (GameObject.Find("NyanCat") != null)
        {
            if (GameObject.Find("NyanCat 1") != null)
            {
                _choix = Random.Range(1, 3);
            }

            else
            {
                _choix = 1;
            }
        }
        
        else
        {
            _choix = 2;
        }
    }

    void FixedUpdate()
    {
        if (_choix == 1)
        {
            Joueur = GameObject.Find("NyanCat");
        }

        if (_choix == 2)
        {
            Joueur = GameObject.Find("NyanCat 1");
        }

        _distance = Vector2.Distance(transform.position, Joueur.transform.position);
        Vector2 direction = Joueur.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 180;

        transform.position = Vector2.MoveTowards(this.transform.position, Joueur.transform.position, _speed * Time.deltaTime);
        transform.rotation = Quaternion.Euler(Vector3.forward * angle);

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
