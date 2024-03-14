using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balleennemi1 : MonoBehaviour
{
    private float speed = 6;
    private float hauteur;
    public float dammage = 1;
    private float _currenttime = 0;
    void Start()
    {
        hauteur = Random.Range(-1.5f, 1.5f);
    }

    void FixedUpdate()
    {
        _currenttime += Time.deltaTime;

        if (_currenttime <= 0.5f)
        {
            transform.Translate(Vector2.up * hauteur * Time.deltaTime);
        }
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "BulletWall")
        {
            Destroy(gameObject);
        }
    }
}