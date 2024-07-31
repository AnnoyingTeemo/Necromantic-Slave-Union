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

    public float secondsInDay;
    private float updateWait;
    private float updateTimeScale = 0.02F;

    public TextMeshProUGUI TimeUI;

    private void MonthlyUpdate() { 
        
    }

    private void FixedUpdate()
    {
        updateWait += updateTimeScale;

        if (updateWait >= secondsInDay) {
            updateWait = 0;
            day += 1;

            if (day > 30) {
                month += 1;
                day = 0;

                if (month > 12) {
                    year += 1;
                    month = 0;
                }
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
        string output = input.ToString();

        if (input < 1000)
        {
            output = "0" + output;
        }
        if (input < 100)
        {
            output = "0" + output;
        }
        if (input < 10)
        {
            output = "0" + output;
        }

        return output;
    }
}
