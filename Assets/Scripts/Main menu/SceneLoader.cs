using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// This class is responsible for
/// the main menu
/// </summary>
public class SceneLoader : MonoBehaviour
{
    TapAudio tapAudioScript;
    StatsVars statsVars;
    Settings settingsScript;
    GameObject mmui, statistics, settings, aboutUs, returnToMenu;
    string[] objNames = { "MMUI", "DisabledStats", "DisabledSet", "DisabledAbout", "DisabledRet" };

    private void Start()
    {
        tapAudioScript = GameObject.FindObjectOfType<TapAudio>();
        statsVars = FindObjectOfType<StatsVars>();
        settingsScript = FindObjectOfType<Settings>();
        mmui = GameObject.Find(objNames[0]);
        statistics = GameObject.Find(objNames[1]);
        settings = GameObject.Find(objNames[2]);
        aboutUs = GameObject.Find(objNames[3]);
        returnToMenu = GameObject.Find(objNames[4]);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        tapAudioScript.PlayTap();
        Time.timeScale = 1;
        statsVars.MatchCount();
    }

    public void Statistics()
    {
        MenuLoader(statistics);
        ReturnToMenuActive();
        statsVars.GetGoals();
    }

    public void Settings()
    {
        MenuLoader(settings);
        ReturnToMenuActive();
        settingsScript.GetSettings();
    }

    public void AboutUs()
    {
        MenuLoader(aboutUs);
        ReturnToMenuActive();
    }

    void ReturnToMenuActive()
    {
        MenuLoader(returnToMenu);
        mmui.SetActive(false);
    }

    void MenuLoader(GameObject obj) // Get all child objects
    {
        Transform[] objChild = obj.GetComponentsInChildren<Transform>(true);
        foreach (var child in objChild)
        {
            child.gameObject.SetActive(true);
        }
    }
}
