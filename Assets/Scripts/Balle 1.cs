using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balle1 : MonoBehaviour
{
    private float speed = 12;

    void FixedUpdate()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}
