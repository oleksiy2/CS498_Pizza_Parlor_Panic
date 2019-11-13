using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btnRouting : MonoBehaviour {
    public Button btnSettings;
    public Button btnExit;
    public Button btnHighScores;
    public Button btnDifficulty;
    public Button btnRestart;

    void Start()
    {
        Button settings = btnSettings.GetComponent<Button>();
        settings.onClick.AddListener(SettingsOnClick);

        Button exit = btnExit.GetComponent<Button>();
        exit.onClick.AddListener(ExitOnClick);

        Button highscore = btnHighScores.GetComponent<Button>();
        highscore.onClick.AddListener(HighScoresOnClick);

        Button difficulty = btnDifficulty.GetComponent<Button>();
        difficulty.onClick.AddListener(DifficultyOnClick);

        Button restart = btnRestart.GetComponent<Button>();
        restart.onClick.AddListener(RestartOnClick);
    }

    void SettingsOnClick()
    {
        Debug.Log("You have clicked Settings!");
    }

    void ExitOnClick()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    void HighScoresOnClick()
    {
        Debug.Log("You have clicked High Scores!");
    }

    void DifficultyOnClick()
    {
        Debug.Log("You have clicked Difficulty!");
    }

    void RestartOnClick()
    {
        Debug.Log("You have clicked Restart!");
    }
}
