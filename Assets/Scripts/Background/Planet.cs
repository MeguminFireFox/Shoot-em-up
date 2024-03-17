using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    private float _currenttime = 0;
    private float _speed = 3;

    void FixedUpdate()
    {
        _currenttime += Time.deltaTime;
        transform.Translate(Vector2.left * _speed * Time.deltaTime);

        if (_currenttime > 30)
        {
            Destroy(gameObject);
        }
    }
}
