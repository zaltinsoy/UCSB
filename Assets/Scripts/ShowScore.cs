using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ShowScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private string strHolder;
    private float contTime;
    private float scoreFlt;
    private float timeRem;

    private void Start()
    {
        scoreText.text = "";
    }
    void Update()
    {
        //scoreText.text = "";
        timeRem= PlayerPrefs.GetFloat("TimeRem");
        contTime = 120 - timeRem;
        if (timeRem <= 0)
        {
            scoreFlt = PlayerPrefs.GetFloat("TotalNeed");
            strHolder = scoreFlt.ToString("0"); 
            scoreText.text = "Your Score: " + strHolder;
        }
        else if (timeRem > 0)

        {
            strHolder = contTime.ToString("0");
            scoreText.text = "You resisted for: " + strHolder + " seconds";
        }
    }
}
