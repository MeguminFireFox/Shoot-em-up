using System.Collections;
using System.Collections.Generic;
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
    }
}
