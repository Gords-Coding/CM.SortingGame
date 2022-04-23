using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    [SerializeField] private string firstScene = "Level1Scene";
    public void changeToFirstScene()
    {
        SceneManager.LoadScene(firstScene);
    }
    public void quitGame()
    {
        Application.Quit();
    }
}
