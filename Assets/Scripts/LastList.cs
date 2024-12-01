using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastList : MonoBehaviour
{
    public PlayerData Data;
    public GameObject Inventory;
    public GameObject commentold;
    public GameObject commentNew;
    bool collectedList;
    // Start is called before the first frame update
    void Start()
    {
        collectedList = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Проверяем, столкнулись ли мы с нужным объектом
        if (collision.gameObject.CompareTag("Paper"))
        {
            collectedList = false;
        }

    }
    void Update()
    {



        if (Input.GetKeyDown(KeyCode.E) && !collectedList && commentold)
        {
            collectedList = true;
            Inventory.SetActive(true);
            commentold.SetActive(false);
            commentNew.SetActive(true);
            
        }
    }
}
