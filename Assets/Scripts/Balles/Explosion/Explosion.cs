using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    private int damage = 5;
    private float presenttime = 0;

    private void FixedUpdate()
    {
        presenttime += Time.deltaTime;

        if (presenttime >= 0.01f)
        {
            Destroy(gameObject);
        }
    }
}
