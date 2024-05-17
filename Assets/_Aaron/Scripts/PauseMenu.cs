using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    public static event Action<bool> TogglePause;

    [SerializeField]
    GameObject pauseMenuScreen;

    private bool gameIsPaused;

    public bool GameIsPaused => gameIsPaused;

    public void OnTogglePauseMenu(InputAction.CallbackContext context)
    {
        if(context.phase == InputActionPhase.Started)
        {
            if (gameIsPaused)
                ResumeGame();
            else
                EnterPauseMenu();
        }
    }

    public void EnterPauseMenu()
    {
        PauseGame();
        pauseMenuScreen.SetActive(true);
    }

    public void PauseGame()
    {
        Cursor.visible = true;
        gameIsPaused = true;
        Time.timeScale = 0f;

        TogglePause?.Invoke(gameIsPaused);
    }

    public void ResumeGame()
    {
        Cursor.visible = false;
        gameIsPaused = false;
        Time.timeScale = 1f;

        pauseMenuScreen.SetActive(false);

        TogglePause?.Invoke(gameIsPaused);

    }
}
