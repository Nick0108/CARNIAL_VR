using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    public Text RemainingTimer;
    public Slider TimeSlider;
    public int RemainingTimerNum = 600;
    public CarnivalScores carnivalScores;
    public Text Score;
    public GameObject GameOverPanel;

    private float timer;
    private int totalScore;

    void BackToLogin()
    {
        SceneManager.LoadScene("Login");
    }

	void Start () {
        RemainingTimer.text = RemainingTimerNum.ToString();
        timer = 0.0f;
        TimeSlider.maxValue = RemainingTimerNum;
        TimeSlider.minValue = 0.0f;
        totalScore = 0;
    }
	
	
	void Update () {
        if (timer > 1.0f)
        {
            RemainingTimerNum--;
            if (RemainingTimerNum <= 0)
                RemainingTimerNum = 0;
            RemainingTimer.text = RemainingTimerNum.ToString();
            TimeSlider.value = (float)RemainingTimerNum;
            timer = 0.0f;
        }
        timer += Time.deltaTime;
        if (RemainingTimerNum <= 0)
        {
            totalScore = carnivalScores.TotalScore();
            Score.text = totalScore.ToString();
            GameOverPanel.SetActive(true);
            Invoke("BackToLogin", 5.0f);
        }
	}
}
