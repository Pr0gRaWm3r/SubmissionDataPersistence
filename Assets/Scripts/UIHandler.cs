using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{
    public TextMeshProUGUI bestScoreText;
    public string playerName;

    public void Start()
    {
        PersistanceManager.Instance.LoadHighScore();
        bestScoreText.text = "Best Score " + PersistanceManager.Instance.playerName + ": " + PersistanceManager.Instance.score;
    }

    public void StartGame()
    {
        if (PersistanceManager.Instance.playerNameSave!= "")
        {
            SceneManager.LoadScene(1);
        }
    }

    public void ReadStringFromInputField(string InputFieldText)
    {
        PersistanceManager.Instance.playerNameSave = InputFieldText;
    }

    public void ExitGame()
    {
        PersistanceManager.Instance.SaveHighScore();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
