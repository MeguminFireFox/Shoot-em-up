using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balle1 : MonoBehaviour
{
    private float speed = 12;
    public float dammage = 1;
    Pelotte ennemie1;

    void FixedUpdate()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "BulletWall")
        {
            Destroy(gameObject);
        }

        if (other.gameObject.tag == "Ennemie")
        {
            Debug.Log("3");
            Destroy(gameObject);
        }
    }
}
