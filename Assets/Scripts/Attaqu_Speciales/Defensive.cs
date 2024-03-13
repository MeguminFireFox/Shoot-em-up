using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

public class Defensive : MonoBehaviour
{
    private bool _isprotected = false;
    private bool _shieldisup = false;
    private float _recharge = 0;
    private float _staytime = 0;
    public GameObject Bouclier;
    public GameObject Joueur;

    public void OnSpecial(InputValue inputValue)
    {
        _isprotected = inputValue.isPressed;
    }

    private void FixedUpdate()
    {
        _recharge += Time.deltaTime;
        Debug.Log(_recharge);
        if (_recharge >= 15)
        {
            if (_isprotected == true)
            {
                _recharge -= _recharge;
                _shieldisup = true;
                Instantiate(Bouclier, Joueur.transform);
            }
        }

        if (_shieldisup == true)
        {
            _staytime += Time.deltaTime;
        }

        if(_staytime >= 5)
        {
            _shieldisup = false;
            _staytime = 0;
            Destroy(GameObject.Find("Shield(Clone)"));
        }
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (_isprotected == true)
        {
            if (other.gameObject.tag == "Ennemie")
            {
                _staytime = 0;
                Destroy(GameObject.Find("Bouclier(Clone)"));
            }

            if (other.gameObject.tag == "EnnemieBullet")
            {
                _staytime = 0;
                Destroy(GameObject.Find("Shield(Clone)"));
            }
        }

    }
}

