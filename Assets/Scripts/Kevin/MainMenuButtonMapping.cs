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
        Debug.Log("Level: Franzls Brezn Paradies wurde ausgewählt!");
    }

    public void OnWeisswurschtFabrikPress()
    {
        Debug.Log("Level: Weißwurscht-Fabrik Niederbayern wurde ausgewählt!");
    }

    public void OnSenfmuehlePress()
    {
        Debug.Log("Level: Senfmühle Otzenhausen wurde ausgewählt!");
    }

    public void OnFestzeltPress()
    {
        Debug.Log("Level: Festzelt Kannstadter-Wasn' wurde ausgewählt!");
    }

    public void OnRemoveAdsPress()
    {
        Debug.Log("You just sold all of your belongings to the devil! Congratulations!");
    }
}
