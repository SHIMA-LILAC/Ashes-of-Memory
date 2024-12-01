using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InventoryMenu : MonoBehaviour
{
    SaveLoadScript Saver;
    public bool OpenInventory;
    public GameObject inventoryGameMenu;
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
        if (Input.GetKeyDown(KeyCode.Tab) && !openedMenu)
        {
            openedMenu = true;
            inventoryGameMenu.SetActive(true);
            Time.timeScale = 0f;
            OpenInventory = true;
            Pause();
        }
        else if (Input.GetKeyDown(KeyCode.Tab) && openedMenu)
        {
            openedMenu = false;
            inventoryGameMenu.SetActive(false);
            Time.timeScale = 1f;
            OpenInventory = false;
            Resume();
        }
    }

    public void Resume()
    {
        inventoryGameMenu.SetActive(false);
        Time.timeScale = 1f;
        OpenInventory = false;
    }

    public void Pause()
    {
        inventoryGameMenu.SetActive(true);
        Time.timeScale = 0f;
        OpenInventory = true;
    }

   

}