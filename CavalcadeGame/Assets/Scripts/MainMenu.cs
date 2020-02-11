using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        GameController.Timer = 60.0f;
        GameController.Score = 0;
    }
    public void QuitGame()
    {
        Application.Quit();

    }
}