using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balle3 : MonoBehaviour
{
    public GameObject Explosion;
    private float speed = 10;
    public float dammage = 3;

    void FixedUpdate()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "BulletWall")
        {
            GameObject go = Instantiate(Explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
    
}
