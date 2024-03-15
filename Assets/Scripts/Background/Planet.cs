using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    private float currenttime = 0;
    private float speed = 3;

    void FixedUpdate()
    {
        currenttime += Time.deltaTime;
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (currenttime > 30)
        {
            Destroy(gameObject);
        }
    }
}
