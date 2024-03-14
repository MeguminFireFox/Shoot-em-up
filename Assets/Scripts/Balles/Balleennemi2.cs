using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balleennemi2 : MonoBehaviour
{
    private float _time = 0;
    private float speed = 8;
    public float Dammage;
    private bool selected;

    void Start()
    {
        Dammage = 3;
    }

    void FixedUpdate()
    {
        transform.localScale = new Vector3(1.5f * _time, 1.5f * _time, 1.5f);
        _time += Time.deltaTime;
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (_time >= 2)
        {
            Dammage = 2;
        }

        if (_time >= 4) 
        {
            Dammage = 1;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "BulletWall")
        {
            Destroy(gameObject);
        }
    }
}
