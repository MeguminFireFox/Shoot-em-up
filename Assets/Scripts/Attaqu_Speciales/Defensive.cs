using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

public class Defensive : MonoBehaviour
{
    private bool _isprotected = false;
    public bool Shieldisup = false;
    private float _recharge = 0;
    private float _staytime = 0;
    public float Hprotected;
    public GameObject Bouclier;
    public GameObject Joueur;
    public GameObject ShieldReady;
    public GameObject ShieldNotReady;

    public void Start()
    {
        PV pv = GetComponent<PV>();
        Hprotected = pv.Health;
    }
    public void OnSpecial(InputValue inputValue)
    {
        PV pv = GetComponent<PV>();
        _isprotected = inputValue.isPressed;
        Hprotected = pv.Health;
    }

    private void FixedUpdate()
    {
        _recharge += Time.deltaTime;
        ShieldReady.SetActive(false);
        ShieldNotReady.SetActive(true);
        if (_recharge >= 15)
        {
            ShieldReady.SetActive(true);
            ShieldNotReady.SetActive(false);
            if (_isprotected == true)
            {
                _recharge -= _recharge;
                Shieldisup = true;
                Instantiate(Bouclier, Joueur.transform);
            }
        }

        if (Shieldisup == true)
        {
            _staytime += Time.deltaTime;
        }

        if(_staytime >= 5)
        {

            Shieldisup = false;
            _staytime = 0;
            Destroy(GameObject.Find("Shield(Clone)"));
        }
        
    }
}

