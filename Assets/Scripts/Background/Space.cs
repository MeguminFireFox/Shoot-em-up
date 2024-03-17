using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space : MonoBehaviour
{
    private float _currenttime = 0;
    private float _speed = 1;

    void FixedUpdate()
    {
        _currenttime += Time.deltaTime;
        transform.Translate(Vector2.left * _speed * Time.deltaTime);

        if (_currenttime > 50)
        {
            Destroy(gameObject);
        }
    }
}