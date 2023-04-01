using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMode : MonoBehaviour
{
    public GameObject ModeUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MainMenu();
        }
    }

    public void MainMenu()
    {
        ModeUI.SetActive(false);
    }

    public void Play()
    {
        ModeUI.SetActive(true);
    }

    public void Classic()
    {
        SceneManager.LoadScene("Classic");
    }

    public void Chaos()
    {
        SceneManager.LoadScene("Chaos");
    }

    public void AI()
    {
        SceneManager.LoadScene("ClassicAI");
    }
}
