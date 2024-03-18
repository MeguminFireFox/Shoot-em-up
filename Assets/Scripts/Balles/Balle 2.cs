using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balle2 : MonoBehaviour
{
    private float speed = 10;
    private float hauteur;
    public float dammage = 1;
    private float _currenttime = 0;

    void Start()
    {
        hauteur = Random.Range(-2, 2);
    }

    void FixedUpdate()
    {
        _currenttime += Time.deltaTime;

        if (_currenttime > 5)
        {
            Destroy(gameObject);
        }

        transform.Translate(Vector2.right * speed * Time.deltaTime);
        transform.Translate(Vector2.up * hauteur * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "BulletWall")
        {
            Destroy(gameObject);
        }
    }
}
