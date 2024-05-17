using System.Collections;
using System.Collections.Generic;
using System.Timers;
using TMPro;
using UnityEngine;

public class UITimer : MonoBehaviour
{
    [SerializeField] private TextMeshPro timerTextBox;

    [SerializeField] private float endTime;

    private bool paused;

    private Timer timer;
    private void OnEnable()
    {
        PauseMenu.TogglePause += OnPauseToggle();
    }
    private void OnDisable()
    {
        PauseMenu.TogglePause -= OnPauseToggle();
    }
    private void Start()
    {
        timer.Start();
    }

    void Update()
    {
        
    }

    private void OnPauseToggle(bool _paused)
    {
        paused = _paused;
    }
}
