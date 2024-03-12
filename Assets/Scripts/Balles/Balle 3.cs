using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balle3 : MonoBehaviour
{
    public GameObject Explosion;
    private float speed = 10;

    void FixedUpdate()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "BulletWall")
        {
            Destroy(gameObject);
            GameObject go = Instantiate(Explosion, transform.position, transform.rotation);
        }
    }
    
}
