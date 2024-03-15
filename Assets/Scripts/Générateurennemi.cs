using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Générateurennemi : MonoBehaviour
{
    private float _time = 0;
    private float _wavechosing = 0;
    public GameObject Ennemi1;
    public GameObject Ennemi2;
    public GameObject Ennemi3;
    public GameObject Ennemi4;
    public GameObject Ennemi5;

    [SerializeField]
    private Vector2 zone;

    void Update()
    {
        _time += Time.deltaTime;

        if (_time >= 2)
        {
            _wavechosing = Random.Range(1, 6);
            _time = 0;
        }

        if (_wavechosing == 1)
        {
            GameObject instantiated = Instantiate(Ennemi1, gameObject.transform);

            instantiated.transform.position = new Vector2(
                Random.Range(transform.position.x - zone.x / 2.5f, transform.position.x + zone.x / 2.5f),
                Random.Range(transform.position.y - zone.y / 5, transform.position.y + zone.y / 5));

            _wavechosing = 0;
        }

        if (_wavechosing == 2)
        {
            GameObject instantiated = Instantiate(Ennemi2, gameObject.transform);

            instantiated.transform.position = new Vector2(
                Random.Range(transform.position.x - zone.x / 2.5f, transform.position.x + zone.x / 2.5f),
                Random.Range(transform.position.y - zone.y / 5, transform.position.y + zone.y / 5));

            _wavechosing = 0;
        }

        if (_wavechosing == 3)
        {
            GameObject instantiated = Instantiate(Ennemi3, gameObject.transform);

            instantiated.transform.position = new Vector2(
                Random.Range(transform.position.x - zone.x / 2.5f, transform.position.x + zone.x / 2.5f),
                Random.Range(transform.position.y - zone.y / 5, transform.position.y + zone.y / 5));

            _wavechosing = 0;
        }

        if (_wavechosing == 4)
        {
            GameObject instantiated = Instantiate(Ennemi4, gameObject.transform);

            instantiated.transform.position = new Vector2(
                Random.Range(transform.position.x - zone.x / 2.5f, transform.position.x + zone.x / 2.5f),
                Random.Range(transform.position.y - zone.y / 5, transform.position.y + zone.y / 5));

            _wavechosing = 0;
        }

        if (_wavechosing == 5)
        {
            GameObject instantiated = Instantiate(Ennemi5, gameObject.transform);

            instantiated.transform.position = new Vector2(
                Random.Range(transform.position.x - zone.x / 2.5f, transform.position.x + zone.x / 2.5f),
                Random.Range(transform.position.y - zone.y / 5, transform.position.y + zone.y / 5));

            _wavechosing = 0;
        }
    }
}
