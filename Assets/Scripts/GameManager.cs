using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // static reference to game manager so can be called from other scripts directly (not just through gameobject component)
    public static GameManager gm;
    public GameObject Player;
    private Scene scene;

    // UI elements to control
    // public GameObject UIGamePaused;
    // public GameObject UIGameOver;

    // private Scene CurrentScene;
    // private Vector3 SpawnLocation;

    // set things up here
    void Awake()
    {
        // setup reference to game manager
        if (gm == null)
            gm = this.GetComponent<GameManager>();
        Player = GameObject.FindGameObjectWithTag("Player");
        Time.timeScale = 1f;

    }

    // game loop
    void Update()
    {


    }


    // setup all the variables, the UI, and provide errors if things not setup properly.


    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadNewScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }



}