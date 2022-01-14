using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class GameBooster : MonoBehaviour
{
    public float activeTime;
    public Text timer;
    public GameObject blockImage;
    private double timerTime;
    public int isActive;
    
    void Update()
    {
        activeTime -= Time.deltaTime;
        timerTime = Math.Round(activeTime, 0);
        Timer();

        if (activeTime <= 0)
        {
            gameObject.SetActive(false);
            isActive = 0;
            blockImage.SetActive(true);
            activeTime = 0;
        }
        else
        {
            gameObject.SetActive(true);
            isActive = 1;
            blockImage.SetActive(false);
        }
    }

    public void Timer()
    {
        int hour = 0;
        int minute = 0;
        int second = 0;
        second = Convert.ToInt32(timerTime);

        if (second >= 60)
        {
            minute = second / 60;
            second = second - minute * 60;
        }

        if (minute >= 60)
        {
            hour = minute / 60;
            minute = minute - hour * 60;
        }

        timer.text = $"{hour}:{minute}:{second}";
    }
}