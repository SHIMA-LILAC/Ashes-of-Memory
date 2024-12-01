using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    SaveLoadScript Saver;
    public bool PauseGame;
    public GameObject pauseGameMenu;
    bool openedMenu;

    private void Start()
    {

        Saver = GetComponent<SaveLoadScript>();


    }

    private void OnDestroy()
    {

    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape) && !openedMenu)
        {
            openedMenu = true;
            pauseGameMenu.SetActive(true);
            Time.timeScale = 0f;
            PauseGame = true;
            Pause();
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && openedMenu)
        {
            openedMenu = false;
            pauseGameMenu.SetActive(false);
            Time.timeScale = 1f;
            PauseGame = false;
            Resume();
        }
    }

    public void Resume()
    {
        openedMenu = false;
        pauseGameMenu.SetActive(false);
        Time.timeScale = 1f;
        PauseGame = false;
    }

    public void Pause()
    {
        openedMenu = true;
        pauseGameMenu.SetActive(true);
        Time.timeScale = 0f;
        PauseGame = true;
    }

    public void LoadMenu()
    {
        Saver.DeleteGame();
        Time.timeScale = 1f;
        SceneManager.LoadScene("1MainMenu");
    }

}