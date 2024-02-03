using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{
    public void StartGame()
    {
        if (PersistanceManager.Instance.playerName != "")
        {
            SceneManager.LoadScene(1);
        }
    }

    public void ReadStringFromInputField(string InputFieldText)
    {
        PersistanceManager.Instance.playerName = InputFieldText;
    }

    public void ExitGame()
    {
        //PersistanceManager.Instance.SaveColor();

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
