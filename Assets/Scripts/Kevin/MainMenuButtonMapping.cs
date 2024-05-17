using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MainMenuButtonMapping : MonoBehaviour
{
    public void OnSettingsPress()
    {
        SceneLoader.Instance.LoadScene(MyScenes.MainMenu);
    }

    public void OnQuitPress()
    {
        EditorApplication.ExitPlaymode();
    }

    public void OnBreznParadiesPress()
    {
        Debug.Log("Level: Franzls Brezn Paradies wurde ausgew�hlt!");
    }

    public void OnWeisswurschtFabrikPress()
    {
        Debug.Log("Level: Wei�wurscht-Fabrik Niederbayern wurde ausgew�hlt!");
    }

    public void OnSenfmuehlePress()
    {
        Debug.Log("Level: Senfm�hle Otzenhausen wurde ausgew�hlt!");
    }

    public void OnFestzeltPress()
    {
        Debug.Log("Level: Festzelt Kannstadter-Wasn' wurde ausgew�hlt!");
    }

    public void OnRemoveAdsPress()
    {
        Debug.Log("You just sold all of your belongings to the devil! Congratulations!");
    }
}
