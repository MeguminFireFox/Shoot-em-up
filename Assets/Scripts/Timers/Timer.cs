using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private float _time = 180f;
    [SerializeField] TMP_Text TimerSetUp;
    public string Scene;

    private void FixedUpdate()
    {
        _time -= Time.deltaTime;
        if (_time > 0)
        {
            float min = Mathf.FloorToInt(_time / 60);
            float sec = Mathf.FloorToInt(_time % 60);
            if (sec < 10)
            {
                TimerSetUp.text = ($"0{min} : 0{sec}");
                return;
            }
            else
            {
                TimerSetUp.text = ($"0{min} : {sec}");
            }
        }
        else if (_time <= 0)
        {
            TimerSetUp.text = "00 : 00";
            SceneManager.LoadScene(Scene);
        }
    }
}
