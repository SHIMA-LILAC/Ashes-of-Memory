using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
   
    public PlayerData Data;
    public GameObject Inventory;
    public GameObject commentold;
    public GameObject commentNew;
    public GameObject chest;
    bool collectedChest;
    public GameObject Les;

    private void Start()
    {

        collectedChest = true;


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Проверяем, столкнулись ли мы с нужным объектом
        if (collision.gameObject.CompareTag("Item"))
        {
            collectedChest = false;
        }

    }
    void Update()
    {

       

        if (Input.GetKeyDown(KeyCode.E) && !collectedChest && commentold)
        {
            collectedChest = true;
            Inventory.SetActive(true);
            commentold.SetActive(false);
            commentNew.SetActive(true);
            chest.SetActive(false);
            Les.SetActive(true);
        }
    }
}
