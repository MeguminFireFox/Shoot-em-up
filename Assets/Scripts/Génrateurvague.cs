using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Génrateurvague : MonoBehaviour
{
    public float _time = 25;
    public GameObject Wave1;
    public GameObject Wave2;
    public float _wavechosing;

    void Update()
    {
        _time += Time.deltaTime;

        if (_time >= 30)
        {
            _wavechosing = Random.Range(1, 3);
            _time = 0;
        }

        if (_wavechosing == 1)
        {
            GameObject go = Instantiate(Wave1, transform.position, transform.rotation);
            _wavechosing = 0;
        }

        if (_wavechosing == 2)
        {
            GameObject go = Instantiate(Wave2, transform.position, transform.rotation);
            _wavechosing = 0;
        }
    }
}
