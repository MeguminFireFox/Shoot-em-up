using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space : MonoBehaviour
{
    private float currenttime = 0;
    private float speed = 1;

    void FixedUpdate()
    {
        currenttime += Time.deltaTime;
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (currenttime > 50)
        {
            Destroy(gameObject);
        }
    }
}