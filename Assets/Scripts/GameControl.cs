using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public float basicMetal;
    public float food;
    public float advancedMetal;
    public float money;

    public float basicMetalIncome;
    public float foodIncome;
    public float advancedMetalIncome;
    public float moneyIncome;

    public int day;
    public int month;
    public int year;

    public int secondsInDay;
    private int seconds = 0;
    private float updateWait;
    private float updateTimeScale = 0.02F;

    public TextMeshProUGUI TimeUI;

    private void MonthlyUpdate() { 
        
    }

    private void FixedUpdate()
    {
        updateWait += updateTimeScale;

        if (updateWait >= 1) {
            seconds += 1;
            updateWait = 0;

            if (seconds >= secondsInDay) {
                day += 1;
                seconds = 0;
            }
        }

        UpdateTimeUI();
    }

    private void UpdateTimeUI() {
        TimeUI.text = twoDigitTextCleanup(day) + "/" + twoDigitTextCleanup(month) + "/" + fourDigitTextCleanup(year);
    }

    private string twoDigitTextCleanup(int input) {
        string output = "";
        
        if (input < 10) { 
            output = "0" + input;
        }
        else
        {
            output = input.ToString();
        }

        return output;
    }

    private string fourDigitTextCleanup(int input)
    {
        return "test";
    }
}
