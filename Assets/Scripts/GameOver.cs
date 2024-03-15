using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject Player;
    public GameObject GameOverObjects;
    public GameObject GameObjects;
    public GameObject GameOverUI;
    public GameObject GameUI;
    private float _time;
    
    private void FixedUpdate()
    {
        TimeTotal timeTotal = GetComponent<TimeTotal>();

        if (GameObject.Find("NyanCat") == null)
        {
            _time += Time.deltaTime;
            GameUI.SetActive(false);
            GameObjects.SetActive(false);
            GameOverUI.SetActive(true);
            GameOverObjects.SetActive(true);

            if (_time >= 1 && _time <= 1.5)
            {
                Instantiate(Player);
                _time += 10;
            }
        }
    }
}
