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

    private float Temps1 = 15;
    private float Temps2 = 7.5f;
    private float Temps3 = 0;

    void Update()
    {
        Temps1 += 1 * Time.deltaTime;
        Temps2 += 1 * Time.deltaTime;
        Temps3 += 1 * Time.deltaTime;

        if (Temps1 >= 22.5f)
        {
            GameObject instantiated = Instantiate(Planet1);

            instantiated.transform.position = new Vector2(
                Random.Range(transform.position.x - zone.x / 2.5f, transform.position.x + zone.x / 2.5f),
                Random.Range(transform.position.y - zone.y / 5, transform.position.y + zone.y / 5));

            Temps1 = 0;
        }

        if (Temps2 >= 22.5f)
        {
            GameObject instantiated = Instantiate(Planet2);

            instantiated.transform.position = new Vector2(
                Random.Range(transform.position.x - zone.x / 2.5f, transform.position.x + zone.x / 2.5f),
                Random.Range(transform.position.y - zone.y / 5, transform.position.y + zone.y / 5));

            Temps2 = 0;
        }

        if (Temps3 >= 22.5f)
        {
            GameObject instantiated = Instantiate(Planet3);

            instantiated.transform.position = new Vector2(
                Random.Range(transform.position.x - zone.x / 2.5f, transform.position.x + zone.x / 2.5f),
                Random.Range(transform.position.y - zone.y / 5, transform.position.y + zone.y / 5));

            Temps3 = 0;
        }
    }
}
