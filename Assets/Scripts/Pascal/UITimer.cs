using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using TMPro;
using UnityEngine;

public class UITimer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerTextBox;

    [SerializeField] private float endTime;

    private bool paused;

    private float timer;
    private void OnEnable()
    {
        PauseMenu.TogglePause += OnPauseToggle;
    }


    private void OnDisable()
    {
        PauseMenu.TogglePause -= OnPauseToggle;
    }
    private void Start()
    {
        timer = 0f;
    }

    void Update()
    {
        var minutes = (int)(timer / 60);
        var seconds = (int)(timer - minutes * 60);
        Debug.Log(minutes.ToString() + ":" + seconds.ToString("00"));
        Debug.Log(((int)minutes).ToString() + ":" + ((int)seconds).ToString("00"));
        timerTextBox.text = ((int)minutes).ToString() + ":" + ((int)seconds).ToString("00");
        if(timer >  endTime)
        {
            TimerIsUp();
        }
        else
        {
            timer += Time.deltaTime;
        }
    }

    private void TimerIsUp()
    {
        SceneLoader.Instance.LoadScene(MyScenes.MainMenu);
    }

    private void OnPauseToggle(bool _paused)
    {
        paused = _paused;
    }
}
