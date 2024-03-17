using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetManager : MonoBehaviour
{
    [SerializeField]
    private GameObject Planet1;
    [SerializeField]
    private GameObject Planet2;
    [SerializeField]
    private GameObject Planet3;
    [SerializeField]
    private Vector2 zone;

    private float _temps1 = 15;
    private float _temps2 = 7.5f;
    private float _temps3 = 0;

    void Update()
    {
        _temps1 += 1 * Time.deltaTime;
        _temps2 += 1 * Time.deltaTime;
        _temps3 += 1 * Time.deltaTime;

        if (_temps1 >= 22.5f)
        {
            GameObject instantiated = Instantiate(Planet1);

            instantiated.transform.position = new Vector2(
                Random.Range(transform.position.x - zone.x / 2.5f, transform.position.x + zone.x / 2.5f),
                Random.Range(transform.position.y - zone.y / 5, transform.position.y + zone.y / 5));

            _temps1 = 0;
        }

        if (_temps2 >= 22.5f)
        {
            GameObject instantiated = Instantiate(Planet2);

            instantiated.transform.position = new Vector2(
                Random.Range(transform.position.x - zone.x / 2.5f, transform.position.x + zone.x / 2.5f),
                Random.Range(transform.position.y - zone.y / 5, transform.position.y + zone.y / 5));

            _temps2 = 0;
        }

        if (_temps3 >= 22.5f)
        {
            GameObject instantiated = Instantiate(Planet3);

            instantiated.transform.position = new Vector2(
                Random.Range(transform.position.x - zone.x / 2.5f, transform.position.x + zone.x / 2.5f),
                Random.Range(transform.position.y - zone.y / 5, transform.position.y + zone.y / 5));

            _temps3 = 0;
        }
    }
}
