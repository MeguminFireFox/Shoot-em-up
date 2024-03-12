using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceManager : MonoBehaviour
{
    private float currenttime = 0;
    public GameObject space;

    void Start()
    {
        GameObject go = Instantiate(space, transform.position, transform.rotation);
    }

    void FixedUpdate()
    {
        currenttime += Time.deltaTime;
        if (currenttime > 22) 
        {
            GameObject go = Instantiate(space, transform.position, transform.rotation);
            currenttime = 0;
        }
    }
}
