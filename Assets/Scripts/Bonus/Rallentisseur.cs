using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rallentisseur : MonoBehaviour
{

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Time.timeScale = 0.33f;
            Destroy(gameObject);
        }
    }
}
