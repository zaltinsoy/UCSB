using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeRemaning;
    public bool timerIsRunning = false;
    public static float timerEnd;
    public TextMeshProUGUI timeText;
    void Start()
    {
        timerIsRunning = true;
    }

    void Update()
    {
        if (timerIsRunning)

        {
            if (timeRemaning > 0)
            {
                timeRemaning -= Time.deltaTime;
                DisplayTime(timeRemaning);
            }
            else
            {
                Debug.Log("bitti!");
                timeRemaning = 0;
                timerIsRunning = false;
                RestartDelay();
            }
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    public void Restart()
    {
        timerEnd = timeRemaning;
        PlayerPrefs.SetFloat("TimeRem", timeRemaning);
        SceneManager.LoadScene("MainMenu");
    }

    public void RestartDelay()
    {
        Invoke("Restart", 1f);
    }
}
