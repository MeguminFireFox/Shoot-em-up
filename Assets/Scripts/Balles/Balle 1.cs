using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balle1 : MonoBehaviour
{
    private float speed = 12;
    public float dammage = 1;

    void FixedUpdate()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "BulletWall")
        {
            Destroy(gameObject);
        }
    }
}
