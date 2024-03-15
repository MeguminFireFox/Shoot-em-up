using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    private float _time = 0;
    [SerializeField] TMP_Text TimerSetUp;

    private void FixedUpdate()
    {
        _time += Time.deltaTime;
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
    }
}
