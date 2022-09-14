using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public float timestart = 60;//само время
    public TMP_Text timerText;//текст таймера
    
    bool timerRunning = false;//сам старт таймера

    private void Start()
    {
        timerText.text = timestart.ToString();
        timerRunning = true;
    }

    private void Update()
    {
        if (timerRunning == true && timestart > 0)
        {
            timestart += Time.deltaTime;
            timerText.text = Mathf.Round(timestart).ToString();
            
        }
        
    }
}
