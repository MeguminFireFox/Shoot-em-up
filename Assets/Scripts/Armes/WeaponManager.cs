using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponManager : MonoBehaviour
{
    public GameObject Joueur;
    public GameObject Automatique;
    public GameObject Shotgun;
    public GameObject Explosif;
    
    private int SwitchWeaponnumber = 1;

    public void OnSwitch(InputValue putValue)
    {
        if (putValue.isPressed == true)
        {
            SwitchWeaponnumber += 1;
        }
    }

    private void FixedUpdate()
    {
        
        if (SwitchWeaponnumber == 1)
        {
            Instantiate(Automatique, Joueur.transform);
            SwitchWeaponnumber += 1;
        }
        
        if (SwitchWeaponnumber == 3)
        {
            Destroy(GameObject.Find("Gun(Clone)"));
            Instantiate(Shotgun, Joueur.transform, worldPositionStays: false);
            SwitchWeaponnumber += 1;
        }

        if (SwitchWeaponnumber == 5)
        {
            Destroy(GameObject.Find("Shotgun(Clone)"));
            Instantiate(Explosif, Joueur.transform, worldPositionStays: false);
            SwitchWeaponnumber += 1;
        }

        if (SwitchWeaponnumber >= 7)
        {
            Destroy(GameObject.Find("Bombs(Clone)"));
            SwitchWeaponnumber = 1;
        }
    }



}
