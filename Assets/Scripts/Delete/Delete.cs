using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    private float presenttime = 0;

    private void FixedUpdate()
    {
        presenttime += Time.deltaTime;

        if (presenttime >= 2f)
        {
            Destroy(gameObject);
            presenttime = 0;
        }
    }
}
