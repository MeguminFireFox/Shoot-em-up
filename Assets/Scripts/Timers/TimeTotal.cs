using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeTotal : MonoBehaviour
{
    public float TimeSetUp = 0;
    [SerializeField] TMP_Text TimerSetUp;

    private void FixedUpdate()
    {
        TimeSetUp += Time.deltaTime;
        if (TimeSetUp > 0)
        {
            float min = Mathf.FloorToInt(TimeSetUp / 60);
            float sec = Mathf.FloorToInt(TimeSetUp % 60);
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
