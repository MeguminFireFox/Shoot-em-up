using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceManager : MonoBehaviour
{
    public GameObject Space;

    private float _currenttime = 0;

    void Start()
    {
        GameObject go = Instantiate(Space, transform.position, transform.rotation);
    }

    void FixedUpdate()
    {
        _currenttime += Time.deltaTime;
        if (_currenttime > 22) 
        {
            GameObject go = Instantiate(Space, transform.position, transform.rotation);
            _currenttime = 0;
        }
    }
}
